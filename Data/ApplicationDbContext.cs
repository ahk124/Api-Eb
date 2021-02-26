
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Utilities;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var entitiesAssembly = typeof(IEntity).Assembly;
            builder.RegisterAllEntities<IEntity>(entitiesAssembly);
            builder.RegisterEntityTypeConfiguration(entitiesAssembly);
        }
    }


}
