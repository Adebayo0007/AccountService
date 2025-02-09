using System.ComponentModel.DataAnnotations;

namespace AccountService_API.DTOs
{
    public class PasswordResetRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
