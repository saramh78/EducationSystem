using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    public class CoursePartRepository : BaseRepository<CoursePart, int>, ICoursePartRepository
    {
        public CoursePartRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}