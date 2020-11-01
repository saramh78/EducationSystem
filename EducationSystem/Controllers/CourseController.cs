using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationSystem.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;

        public CourseController(ICategoryService categoryService, ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
        }

        [HttpPost]
        public async Task<ActionResult<CourseDetailDto>> AddCourseWithRelations(CourseWithRelaitionsDto courseWithRelaitionsDto)
        {
            var service = await _courseService.AddCourseWithRelations(courseWithRelaitionsDto);
            return service;
        }
    }
}
