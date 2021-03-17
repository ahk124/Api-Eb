using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.User;

namespace Entities.DTO
{
    public class UserDTO:IValidatableObject
    {
        [Required]
        [StringLength(100)]
        // [Microsoft.AspNetCore.Mvc.Remote("IsUserNameInUse", "Account",HttpMethod="POST",AdditionalFields="__RequestVerificationToken")]
        public string UserName { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int Age { get; set; }

        public GenderType Gender { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}