using MailSender.Model.Interface;

namespace MailSender.Model.Entity
{
    public class SendMailDetail : ISendMailDetail
    {
        public string EMail { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
    }
}
