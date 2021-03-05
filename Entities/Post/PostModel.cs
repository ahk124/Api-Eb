using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Post
{
    [Table("Posts")]
    public class PostModel:BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthurId { get; set; }

        public CategoryModel Category { get; set; }
        public UserModel Author { get; set; }
    }
    public class PostModelConfiguration : IEntityTypeConfiguration<PostModel>
    {
        public void Configure(EntityTypeBuilder<PostModel> builder)
        {
            builder.Property(p=>p.Title).IsRequired().HasMaxLength(200);
            builder.Property(p=>p.Description).IsRequired();
            builder.HasOne(p=>p.Category).WithMany(c=>c.Posts).HasForeignKey(p=>p.CategoryId);
            builder.HasOne(p=>p.Author).WithMany(c=>c.Posts).HasForeignKey(p=>p.AuthurId);
        }
    }
}