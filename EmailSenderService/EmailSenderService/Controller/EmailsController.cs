using business.EmaileSender.Interface;
using data.EmailService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace presentation.EmailSender.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailSenderService _emailSenderService;
        public EmailsController(IEmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }

        public IEmailSenderService EmailSenderService { get; }

        [HttpPost]
        public async Task<IActionResult> SendEmailAsynch()
        { 
            await _emailSenderService.SendEmailAsync();
            return Ok();
        }
    }
}
