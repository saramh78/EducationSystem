using System.Collections.Generic;

namespace EducationSystem.Dtos
{
    public class CategoryWithCategoryDto
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public List<CourseDto> Courses { get; set; }
        public List<CategoryWithCategoryDto> Children { get; set; }
    }
}
