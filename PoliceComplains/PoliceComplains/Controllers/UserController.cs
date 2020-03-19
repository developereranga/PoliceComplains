using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PoliceComplains.Entities;
using PoliceComplains.Service;

namespace PoliceComplains.Controllers
{
    public class UserController : Controller
    {
        private readonly PoliceComplainsContext _context;
        private readonly DataProtectionService _dataProtectionService;
        private readonly EmailService _emailService;
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration, EmailService emailService, PoliceComplainsContext context,
            DataProtectionService dataProtectionServiceService)
        {
            _configuration = configuration;
            _emailService = emailService;
            _dataProtectionService = dataProtectionServiceService;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpPost]
        public IActionResult ResetPassword(User post)
        {
            var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
            var user = _context.User.First(x => x.Id.Equals(Convert.ToInt32(userId)));
            user.Password = _dataProtectionService.ToMd5(post.Password);
            _context.User.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Account");
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateInfo(User post)
        {
            var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
            var user = _context.User.First(x => x.Id.Equals(Convert.ToInt32(userId)));
            user.FirstName = post.FirstName;
            user.LastName = post.LastName;
            user.Address = post.Address;
            user.TelephoneNumber = post.TelephoneNumber;
            user.Email = post.Email;
            user.NicNumber = post.NicNumber;
            _context.User.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Account");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(User post)
        {
            try
            {
                var user = _context.User.FirstOrDefault(x =>
                    x.Email.Equals(post.Email) && x.Password.Equals(_dataProtectionService.ToMd5(post.Password)));
                if (user == null)
                {
                    ViewBag.error = "Username or password wrong";
                    return View();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                    new Claim(ClaimTypes.Sid, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                var claimPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimPrincipal);

                switch (user.Role)
                {
                    case "client":
                        return RedirectToAction("Client", "Dashboard");

                    case "admin":
                        return RedirectToAction("Admin", "Dashboard");
                    default:
                        return View();
                }
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View();
            }
        }

        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [Authorize]
        public IActionResult Account()
        {
            var userId = HttpContext.User.Claims.First(x => x.Type.Equals(ClaimTypes.Sid)).Value;
            ViewBag.user = _context.User.First(x => x.Id.Equals(Convert.ToInt32(userId)));

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult SignUp(User user)
        {
            try
            {
                user.Role = "client";
                user.Password = _dataProtectionService.ToMd5(user.Password);
                _context.User.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login", "User");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
            }

            return View();
        }

        [AllowAnonymous]
        public IActionResult RecoverPassword()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RecoverPassword(User post)
        {
            try
            {
                var user = _context.User.FirstOrDefault(x => x.Email.ToLower().Equals(post.Email.ToLower()));
                if (user == null)
                {
                    ViewBag.error = "User not found";
                    return View();
                }

                var password = Guid.NewGuid().ToString("N");
                user.Password = _dataProtectionService.ToMd5(password);
                _context.User.Update(user);
                _context.SaveChanges();
                var html = _configuration.GetSection("Email:PasswordResetMail").Value;
                html = html.Replace("@newpassword", password);
               await _emailService.Send(user.Email, "Password reset", html);
                return RedirectToAction("Login", "User");
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}