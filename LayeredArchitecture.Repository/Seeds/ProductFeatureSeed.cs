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
    class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature { Id = 1, Color = "Red", Height = 200, Width = 300, ProductId = 1 },
                new ProductFeature { Id = 1, Color = "Blue", Height = 350, Width = 300, ProductId = 2 },
                new ProductFeature { Id = 1, Color = "Green", Height = 240, Width = 300, ProductId = 3 },
                new ProductFeature { Id = 1, Color = "Black", Height = 320, Width = 300, ProductId = 4 },
                new ProductFeature { Id = 1, Color = "White", Height = 210, Width = 300, ProductId = 6 },
                new ProductFeature { Id = 1, Color = "Yellow", Height = 740, Width = 300, ProductId = 7 },
                new ProductFeature { Id = 1, Color = "Red", Height = 480, Width = 300, ProductId = 8 },
                new ProductFeature { Id = 1, Color = "White", Height = 200, Width = 300, ProductId = 9 }
                );
        }
    }
}
