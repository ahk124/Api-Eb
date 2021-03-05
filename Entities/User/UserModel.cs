using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Post;

namespace Entities.User
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Users")]
    public class UserModel:BaseEntity
    {
        public UserModel()
        {
            this.Posts = new HashSet<PostModel>();
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

        public ICollection<PostModel> Posts { get; set; }
    }

    public enum GenderType
    {
        Male = 1,
        Female = 2
    }
}