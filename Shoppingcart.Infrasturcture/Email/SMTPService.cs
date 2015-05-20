using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Shoppingcart.Infrasturcture.Domain.Configuration;
using System.Net;

namespace Shoppingcart.Infrasturcture.Email
{
    public class SMTPService : IEmailService
    {
        public void SendMail { get; set; }

        public void SendMail(string from, string to, string subject, string body)
        {
            MailMessage message = new MailMessage();

            message.From = new MailAddress(from);
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.Normal;

            string userName = ApplicationSettingsFactory.GetApplicationSettings().EmailAddress;
            string password = ApplicationSettingsFactory.GetApplicationSettings().Credential;

            SmtpClient smtp = new SmtpClient("smtp.mailinator.com", Convert.ToInt32(25));
            smtp.Credentials = new NetworkCredential(userName, password);
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
