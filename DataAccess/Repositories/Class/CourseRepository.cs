using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    public class CourseRepository : BaseRepository<Course, int>, ICourseRepository
    {
        public CourseRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}
