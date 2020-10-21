using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    public class CoursePartArticleRepository : BaseRepository<CoursePartArticle, int>, ICoursePartArticleRepository
    {
        public CoursePartArticleRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}
