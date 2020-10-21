using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Class
{
    public class CategoryRepository:BaseRepository<Category,int>,ICategoryRepository
    {
        public CategoryRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {
        }

        public override async Task<Category> FindAsync(int id)
        {
            return await _context.Set<Category>()
                .Include(x => x.Courses)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

