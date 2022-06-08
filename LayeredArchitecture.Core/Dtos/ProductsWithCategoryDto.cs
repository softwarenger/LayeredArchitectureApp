using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Dtos
{
    public class ProductsWithCategoryDto : ProductDto
    {
        public Category Category { get; set; }
    }
}
