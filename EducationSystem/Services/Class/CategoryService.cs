using EducationSystem.Dtos;
using EducationSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repositories.Class;
using DataAccess.Repositories.Interface;
using EducationSystem.Mapper;

namespace EducationSystem.Services.Class
{
    public class CategoryService:ICategoryService
    {
        private const int _SYSTEMUSERID = 1;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICourseRepository _courseRepository;
        public CategoryService(ICategoryRepository categoryRepository, ICourseRepository courseRepository)
        {
            this._categoryRepository = categoryRepository;
            this._courseRepository = courseRepository;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.CategoriesToCategoryDtos();
        }

        public async Task<CategoryDetailDto> GetAsync(int categoryId)
        {
            var category = await _categoryRepository.FindAsync(categoryId);
            if (category == null)
            {
                throw new Exception("category Not Found");
            }
            return category.CategoryToCategoryDetailDto();
        }


        public async Task<List<CategoryWithCategoryDto>> GetWithChildrenAsync(int categoryId, int level)
        {
            var categories = await _categoryRepository.FindWithChildrenAsync(categoryId,level);
            if (categories == null)
            {
                throw new Exception("category Not Found");
            }
            return categories.CategoriesToCategoriesWithCategoryDto();
        }
    }
}
