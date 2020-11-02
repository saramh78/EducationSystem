using EducationSystem.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationSystem.Services.Interface
{
    public interface ICourseService
    {
        public Task<CourseDetailDto> AddCourseWithRelations(CourseDetailDto courseDetailDto);
        public Task<List<CourseDto>> GetAllAsync();
        public Task<CourseDetailDto> GetAsync(int courseId);
    }
}
