using LayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Altus", Price = 7500, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 2, Name = "Beko", Price = 5500, Stock = 30, CreatedDate = DateTime.Now }
                );
        }
    }
}
