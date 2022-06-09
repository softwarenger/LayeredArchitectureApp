using AutoMapper;
using LayeredArchitecture.Core;
using LayeredArchitecture.Core.Dtos;
using LayeredArchitecture.Core.Repositories;
using LayeredArchitecture.Core.Services;
using LayeredArchitecture.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> genericRepository, ICategoryRepository categoryRepository, IMapper mapper) : base(unitOfWork, genericRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryByIdWithProductsAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);
            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDto);

        }
    }
}
