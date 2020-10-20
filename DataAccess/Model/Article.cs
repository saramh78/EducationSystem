using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class Article
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<CoursePartArticle> CoursePartArticles { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
