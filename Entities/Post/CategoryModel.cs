using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Categories")]
    public class CategoryModel : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }

        [ForeignKey(nameof(ParentCategoryId))]
        public CategoryModel ParentCategory { get; set; }
        public ICollection<CategoryModel> ChildCategories { get; set; }
        public ICollection<PostModel> Posts { get; set; }
    }
}