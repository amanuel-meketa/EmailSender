using data.EmailService.Model;

namespace business.EmaileSender.Interface
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync();
    }
}
