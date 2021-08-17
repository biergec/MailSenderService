using MailSender.Model.Entity;

using MassTransit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSenderService.Sender.Consumer
{
    public class MailConsumer : IConsumer<SendMailDetail>
    {
        public async Task Consume(ConsumeContext<SendMailDetail> context)
        {
            var data = context.Message;
            Console.WriteLine(data);
        }
    }
}
