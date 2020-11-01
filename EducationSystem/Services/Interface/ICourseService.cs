using EducationSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Services.Interface
{
    public interface ICourseService
    {
        public Task<CourseDetailDto> AddCourseWithRelations(CourseDetailDto courseDetailDto);
    }
}
