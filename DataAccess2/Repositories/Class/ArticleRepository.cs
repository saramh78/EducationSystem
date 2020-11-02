using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;

namespace DataAccess.Repositories.Class
{
    public class ArticleRepository:BaseRepository<Article,int>,IArticleRepository
    {
        public ArticleRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {
        }
    }
}
