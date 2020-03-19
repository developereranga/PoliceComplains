using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PoliceComplains.Service
{
    public class EmailService
    {
        private readonly SmtpClient _mailClient;
        private readonly IConfiguration _systemConfiguration;

        public EmailService(IConfiguration systemConfiguration)
        {
            _systemConfiguration = systemConfiguration;

            _mailClient = new SmtpClient(systemConfiguration.GetSection("Email:OutgoingServer").Value);
            _mailClient.Port = int.Parse(systemConfiguration.GetSection("Email:ServerPort").Value);
            _mailClient.EnableSsl = true;
            _mailClient.UseDefaultCredentials = false;
            _mailClient.Credentials = new NetworkCredential(systemConfiguration.GetSection("Email:Username").Value,
                systemConfiguration.GetSection("Email:Password").Value);
        }

        public async Task<bool> Send(string to, string subject, string body)
        {
            var mailMessage = new MailMessage(_systemConfiguration.GetSection("Email:Username").Value, to);

            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;
            mailMessage.Subject = subject;
            await _mailClient.SendMailAsync(mailMessage);
            return true;
        }
    }

}
