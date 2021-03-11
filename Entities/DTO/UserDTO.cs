using System.ComponentModel.DataAnnotations;
using Entities.User;

namespace Entities.DTO
{
    public class UserDTO
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int Age { get; set; }

        public GenderType Gender { get; set; }
    }
}