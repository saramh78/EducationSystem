using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class Article:BaseEntity<int>
    {
        public string Text { get; set; }
        public ICollection<CoursePartArticle> CoursePartArticles { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
