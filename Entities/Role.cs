using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Roles")]
    public class Role:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}