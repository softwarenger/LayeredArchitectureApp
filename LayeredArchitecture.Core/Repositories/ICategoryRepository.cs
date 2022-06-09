using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Repositories
{
    public interface ICategoryRepository :IGenericRepository<Category>
    {
        Task<Category> GetCategoryByIdWithProductsAsync(int categoryId);
    }
}
