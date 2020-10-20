using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class CoursePart
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
        public ICollection<CoursePartArticle> CoursePartArticles { get; set; }
    }
}
