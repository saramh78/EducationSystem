using DataAccess.Model;
using EducationSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EducationSystem.Mapper
{
    public static class CategoryMapper
    {
        public static CategoryDto CategoryToCategoryDtoForGet(this Category category)
        {
            return new CategoryDto()
            {
                Id = category.Id,
                ParentId = category.ParentId,
                Name = category.Name,
                            
            };
        }

        public static CategoryDetailDto CategoryToCategoryDetailDto(this Category category)
        {
            return new CategoryDetailDto()
            {
                Id = category.Id,
                ParentId = category.ParentId,
                Name = category.Name,
                CourseDtos = category.Courses != null ? category.Courses.Select(x => new CourseDto() {Id=x.Id, Name=x.Name }).ToList() : null,
               

            };
        }

        public static List<CategoryDto> CategoriesToCategoryDtos(this List<Category> Categories)
        {
            if (Categories == null)
            {
                throw new ArgumentNullException(nameof(Categories));
            }
            var CategoryDtos = new List<CategoryDto>();
            for (int i = 0; i < Categories.Count; i++)
            {
                CategoryDtos.Add(Categories[i].CategoryToCategoryDtoForGet());
            }

            return CategoryDtos;
        }
    }
}
