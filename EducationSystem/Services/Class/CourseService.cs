using DataAccess.Repositories.Interface;
using EducationSystem.Dtos;
using EducationSystem.Mapper;
using EducationSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var course1 = courseDetailDto.CourseDtoToCourse();
            var service =await _courseRepository.AddAsync(course1);
            return service.CourseToCourseDto();
        }
    }
}
