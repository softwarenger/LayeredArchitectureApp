using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Dtos
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }


        public int CategoryId { get; set; }
    }
}
