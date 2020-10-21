using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    public class ArticleRepository:BaseRepository<Article,int>,IArticleRepository
    {
        public ArticleRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {
        }
    }
}
