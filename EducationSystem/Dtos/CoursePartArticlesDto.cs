using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Model;

namespace EducationSystem.Dtos
{
    public class CoursePartArticlesDto
    {
        public int CoursePartId { get; set; }
        public int ArticleId { get; set; }
        public int Order { get; set; }
        
    }
}
