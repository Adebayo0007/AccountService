using System.ComponentModel.DataAnnotations;

namespace AccountService_API.DTOs
{
    public class CreateRoleRequestModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
