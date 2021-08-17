namespace MailSender.Model.Interface
{
    public interface ISendMailDetail
    {
        public string EMail { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
    }
}
