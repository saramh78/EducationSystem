using EducationSystem.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationSystem.Services.Interface
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDetailDto> GetAsync(int categoryId);
        Task<List<CategoryWithCategoryDto>> GetWithChildrenAsync(int categoryId, int level);
    }
}
