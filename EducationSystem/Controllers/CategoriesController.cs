﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationSystem.Dtos;
using EducationSystem.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;

        public CategoriesController(ICategoryService categoryService, ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetAllAsync()
        {
            var service = await _categoryService.GetAllAsync();
            return service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDetailDto>> GetAsync(int id)
        {
            var service = await _categoryService.GetAsync(id);
            return service;
        }
    }
}
