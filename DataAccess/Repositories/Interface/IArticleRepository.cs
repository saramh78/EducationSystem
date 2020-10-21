using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Interface
{
    public interface IArticleRepository : IBaseRepository<Article, int>
    {
    }
}
