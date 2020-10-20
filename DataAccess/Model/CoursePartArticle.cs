using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class CoursePartArticle
    {
        public int Id { get; set; }
        public int CoursePartId { get; set; }
        public int ArticleId { get; set; }
        public int Order { get; set; }
        public CoursePart CoursePart { get; set; }
        public Article Article { get; set; }
    }
}
