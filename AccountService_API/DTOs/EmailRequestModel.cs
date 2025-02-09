namespace AccountService_API.DTOs
{
    public class EmailRequestModel
    {
        public string? SenderEmail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverEmail { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string? OTP { get; set; }
        public string? Number { get; set; }
    }
}
