using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Dtos
{
    public class ArticleInsertApiModel
    {
        public string Text { get; set; }
        public int Order { get; set; }
        // public List<CoursePartArticlesDto> CoursePartArticles { get; set; }
        public List<LinkDto> Links { get; set; }
    }
}
