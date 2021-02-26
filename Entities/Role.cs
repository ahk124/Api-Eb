using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Role:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}