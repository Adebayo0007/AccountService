using AccountService_API.DTOs;

namespace AccountService_API.Services.Interfaces
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailRequestModel email);
        Task<bool> EmailValidaton(string email);
        Task<bool> SendEmail1(EmailRequestModel mail);
    }
}
