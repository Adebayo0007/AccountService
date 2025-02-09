using System.ComponentModel.DataAnnotations;

namespace AccountService_API.DTOs
{
    public class LoginRequestModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
