using DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interface
{
    public interface ICategoryRepository:IBaseRepository<Category, int>
    {
        Task<List<Category>> FindWithChildrenAsync(int id, int level);
    }
}
