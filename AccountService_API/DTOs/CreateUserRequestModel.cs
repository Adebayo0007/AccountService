using System.ComponentModel.DataAnnotations;

namespace AccountService_API.DTOs
{
    public class CreateUserRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
