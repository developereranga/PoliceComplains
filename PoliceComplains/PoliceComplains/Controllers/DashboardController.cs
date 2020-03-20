using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliceComplains.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoliceComplains.Service;


namespace PoliceComplains.Controllers
{
    public class DashboardController : Controller
    {
        private readonly PoliceComplainsContext _context;
        private readonly IHostingEnvironment _env;
        private readonly EmailService _emailService;
        private readonly DataProtectionService _dataProtectionService;
        private readonly IConfiguration _configuration;

        public DashboardController(DataProtectionService dataProtectionService, PoliceComplainsContext context,
            IHostingEnvironment env, EmailService emailService, IConfiguration configuration)
        {
            _dataProtectionService = dataProtectionService;
            _configuration = configuration;
            _emailService = emailService;
            _context = context;
            _env = env;
        }

        [Authorize(Roles = "client")]
        public IActionResult Client()
        {
            var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;

            ViewBag.complains = _context.Complains.Where(x => x.UserId.Equals(Convert.ToInt32(userId))).ToList();
            return View();
        }

        [Authorize(Roles = "client")]
        public IActionResult ClientNewComplain()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult EditDoc()
        {
            ViewBag.doc = _context.Docs.First();
            return View();
        }
        [HttpPost]
        public IActionResult EditDoc(Docs post)
        {
            var doc = _context.Docs.First();
            doc.Content = post.Content;
            _context.Docs.Update(doc);
            _context.SaveChanges();
            return Json(new { status=true});
        }

        [Authorize]
        public IActionResult ViewComplain(int id)
        {
            try
            {
                var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
                ViewBag.userId = Convert.ToInt32(userId);
                ViewBag.complain = _context.Complains.Include(x => x.ComplainDocs).Include(x => x.ComplainFeedback)
                    .First(x => x.Id.Equals(id));
                return View();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "client")]
        [HttpPost]
        public async Task<IActionResult> AddComplainDoc(IFormFile ufile)
        {
            try
            {
                var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
                var fileName = Path.GetFileName(ufile.FileName);
                string nameOnly = Path.GetFileNameWithoutExtension(fileName);
                fileName = fileName.Replace(nameOnly, Guid.NewGuid().ToString("N")).ToLower();
                string userFolder = Path.Combine(_env.WebRootPath, userId);
                if (!Directory.Exists(userFolder))
                    Directory.CreateDirectory(userFolder);

                string filePath = Path.Combine(userFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }

                return Json(new {fileName});
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return View();
        }

        [Authorize]
        public IActionResult PrintComplain(int cid)
        {

            try
            {
                ViewBag.comp = _context.Complains.Include(x=>x.ComplainFeedback).ThenInclude(x=>x.User).First(x => x.Id.Equals(cid));
                return View();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [Authorize(Roles = "client")]
        [HttpPost]
        public async Task<IActionResult> ClientNewComplain(Complains post)
        {
            try
            {
                var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
                post.UserId = Convert.ToInt32(userId);
                post.ComplainDocs = new List<ComplainDocs>();
                if (!string.IsNullOrEmpty(post.Status))
                {
                    post.Status.Split(",").ToList().ForEach(f =>
                    {
                        var fvar = f.Split("*");
                        post.ComplainDocs.Add(new ComplainDocs() {FileName = fvar[0], RealName = fvar[1]});
                    });
                }

                post.Status = "Pending";
                _context.Complains.Add(post);
                _context.SaveChanges();
                var user = _context.User.First(x => x.Id.Equals(Convert.ToInt32(userId)));

                var html = _configuration.GetSection("Email:ComplainCreatedMail").Value;
                html = html.Replace("@title", post.Title);
                html = html.Replace("@description", post.Description);
              await  _emailService.Send(user.Email, "New Complain Created", html);
                return Json(new {status = true});
            }
            catch (Exception e)
            {
                return Json(new {status = false});
            }
        }

        [HttpGet("{cid}")]
        [Authorize(Roles = "admin")]
        public IActionResult CaseClose(int caseId)
        {
            try
            {
                var c = _context.Complains.First(x => x.Id.Equals(caseId));
                c.Status = "Case closed";
                _context.Complains.Update(c);
                _context.SaveChanges();
                return RedirectToAction("ViewComplain", new {id = caseId});
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "admin")]
        public IActionResult CreateAdminAccount()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult CreateAdminAccount(User user)
        {
            try
            {
                user.Role = "admin";
                user.Password = _dataProtectionService.ToMd5(user.Password);
                _context.User.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Admin", "Dashboard");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult SendMessage(ComplainFeedback post)
        {
            try
            {
                var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
                var role = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Role)).Value;

                post.UserId = Convert.ToInt32(userId);
                _context.ComplainFeedback.Add(post);


                if (role.Equals("admin"))
                {
                    var comp = _context.Complains.First(x => x.Id.Equals(post.ComplainId));
                    comp.Status = "In Progress";
                    _context.Complains.Update(comp);
                }

                _context.SaveChanges();

                return RedirectToAction("ViewComplain", new {id = post.ComplainId});
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        //====================================================
        public IActionResult Admin(string status = null)
        {
            if (status != null)
            {
                ViewBag.complains = _context.Complains.Where(x => x.Status.ToLower().Equals(status.ToLower())).ToList();
            }
            else
            {
                ViewBag.complains = _context.Complains.ToList();
            }

            return View();
        }
    }
}