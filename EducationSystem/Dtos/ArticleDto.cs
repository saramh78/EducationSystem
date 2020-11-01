﻿using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Dtos
{
    public class ArticleDto
    {
        public string Text { get; set; }

        public List<LinkDto> Links { get; set; }
    }
}
