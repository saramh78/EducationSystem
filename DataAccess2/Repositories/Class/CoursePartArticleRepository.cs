using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;

namespace DataAccess.Repositories.Class
{
    public class CoursePartArticleRepository : BaseRepository<CoursePartArticle, int>, ICoursePartArticleRepository
    {
        public CoursePartArticleRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}
