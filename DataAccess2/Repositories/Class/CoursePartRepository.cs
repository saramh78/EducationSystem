using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;

namespace DataAccess.Repositories.Class
{
    public class CoursePartRepository : BaseRepository<CoursePart, int>, ICoursePartRepository
    {
        public CoursePartRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}