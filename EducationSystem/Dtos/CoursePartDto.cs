using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Dtos
{
    public class CoursePartDto
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public List<ArticleInsertApiModel> Articles { get; set; }
    }
}
