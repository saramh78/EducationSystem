using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Dtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<CoursePartArticle> CoursePartArticles { get; set; }
        public List<Link> Links { get; set; }
    }
}
