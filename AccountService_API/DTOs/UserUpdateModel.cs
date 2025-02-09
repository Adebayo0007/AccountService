using System.ComponentModel.DataAnnotations;

namespace AccountService_API.DTOs
{
    public class UserUpdateModel
    {
        [Required]
        public string UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phonenumber { get; set; }
    }
}
