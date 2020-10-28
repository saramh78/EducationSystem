using DataAccess.Model;
using DataAccess.ViewDataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interface
{
    public interface ICategoryRepository:IBaseRepository<Category, int>
    {
        Task<List<Category>> FindWithChildrenAsync(int id, int level);
    }
}
