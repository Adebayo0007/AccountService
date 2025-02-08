using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountService_API.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PasswordOTP { get; set; }
        public string? Gender { get; set; }
        public string? RefreshToken { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
        public string? CreatorName { get; set; }
        public string? CreatorId { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsModified { get; set; }
        public string? ModifierName { get; set; }
        public string? ModifierId { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
