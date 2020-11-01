using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Dtos
{
    public class LinkDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Url { get; set; }
        public LinkType LinkType { get; set; }
    }
}
