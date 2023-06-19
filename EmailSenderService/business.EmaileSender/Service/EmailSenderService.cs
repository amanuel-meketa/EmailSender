using business.EmaileSender.Interface;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using data.EmailService.Model;

namespace business.EmaileSender.Service
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _username = "email";
        private readonly string _password = "pass";
        private readonly string _to = "test@gmail.com";
        private readonly string subject = "test";
        private readonly string message = "test from asp.net core project";

        public async Task SendEmailAsync()
        {
            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(_username, _password);

                var mailMessage = new MailMessage(_username, _to, subject, message);
                await client.SendMailAsync(mailMessage);
            }
        }
    }
}
