using LayeredArchitecture.Core.Dtos;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProductsAsync(int categoryId);

    }
}
