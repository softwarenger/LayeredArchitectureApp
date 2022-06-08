using LayeredArchitecture.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Services
{
    public interface IProductService :IService<Product>
    {
        Task <CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategory();
    }
}
