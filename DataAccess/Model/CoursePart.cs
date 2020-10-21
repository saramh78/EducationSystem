﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class CoursePart : BaseEntity<int>
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
        public ICollection<CoursePartArticle> CoursePartArticles { get; set; }
    }
}
