using MailSender.Model.Entity;

using MassTransit;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Threading.Tasks;

namespace MailSenderService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IBus _bus;
        public MailController(IBus bus)
        {
            this._bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] SendMailDetail sendMailDetail)
        {
            if (sendMailDetail != null)
            {
                //send.mail
                Uri uri = new Uri("rabbitmq://localhost/send.mail");
                var endPoint = await _bus.GetSendEndpoint(uri);
                await endPoint.Send(sendMailDetail);
                return Ok();
            }

            return BadRequest();
        }
    }
}
