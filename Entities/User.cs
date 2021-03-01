using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Users")]
    public class User:BaseEntity
    {
        public User()
        {
            IsActive = true;
        }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public enum GenderType
    {
        Male = 1,
        Female = 2
    }
}