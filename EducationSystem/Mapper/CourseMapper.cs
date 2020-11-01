using DataAccess.Model;
using EducationSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Mapper
{
    public static class CourseMapper
    {
        public static Course CourseDtoToCourse(this CourseDetailDto courseDetailDto)
        {
            var course = new Course()
            {
                Name = courseDetailDto.Name,
                Description = courseDetailDto.Description,
                CategoryId = courseDetailDto.CategoryId,
                CourseParts = courseDetailDto.CourseParts.Select(cp => new CoursePart
                {
                     Title = cp.Title, 
                     Order = cp.Order,
                     CoursePartArticles = cp.Articles.GetArticleDto()
                }).ToList()
            };
            return course;

        }


        public static CourseDetailDto CourseToCourseDto(this Course course)
        {
            var courseDto = new CourseDetailDto()
            {
                Name = course.Name,
                Description = course.Description,
                CategoryId = course.CategoryId,
                CourseParts = course.CourseParts.Select(x=> x.CoursePartToCoursePartDto()).ToList()
            };
            return courseDto;
        }

        
    }
}
