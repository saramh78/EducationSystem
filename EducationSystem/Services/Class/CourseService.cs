using DataAccess.Repositories.Interface;
using EducationSystem.Dtos;
using EducationSystem.Mapper;
using EducationSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationSystem.Services.Class
{
    public class CourseService:ICourseService
    {
        private const int _SYSTEMUSERID = 1;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICategoryRepository categoryRepository, ICourseRepository courseRepository)
        {
            this._categoryRepository = categoryRepository;
            this._courseRepository = courseRepository;
        }

        public async Task<CourseDetailDto> AddCourseWithRelations(CourseDetailDto courseDetailDto)
        {
            var course1 = courseDetailDto.CourseDetailDtoToCourse();
            var service =await _courseRepository.AddAsync(course1);
            return service.CourseToCourseDetailDto();
        }

        public async Task<List<CourseDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            return courses.CoursesToCourseDtos();
        }

        public async Task<CourseDetailDto> GetAsync(int courseId)
        {
            var course = await _courseRepository.FindAsync(courseId);
            if (course == null)
            {
                throw new Exception("Course Not Found");
            }
            return course.CourseToCourseDetailDto();
        }
    }
}
