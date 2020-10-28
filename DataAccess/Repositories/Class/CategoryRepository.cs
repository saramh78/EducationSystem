using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using DataAccess.ViewDataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Class
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
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

        public async Task<List<Category>> FindWithChildrenAsync(int id, int level)
        {
            List<CategoryParsed> categories = new List<CategoryParsed>();
            var find = _context.Categories.FirstOrDefault(x => x.Id.Equals(id));
            categories.Add(new CategoryParsed { Categ=find, level=0, Parsed=false});

            while(categories.Any(x=>!x.Parsed))
            {
                var r = categories.FirstOrDefault(x => !x.Parsed);
                if(level !=-1 && r.level>=level)
                {

                }
                else
                {
                    var child=_context.Categories.Where(x=>x.ParentId==x.)
                }
            }
            CategoryParsed c = new CategoryParsed
            {
                Category = a,
                level = 0,
                Parsed = false
            };
            

            while (cate)
            {
                if (level != -1 && c.level >= level)
                { 
                    c.Parsed = true;
                    c.level++;
                }
                else
                {                   
                    categories.AddRange(await _context.Set<Category>().Where(s => s.ParentId == c.Category.Id).ToListAsync());
                    i++;
                    c.Category = categories[i];
                    c.Parsed = true;
                    if(categories[i].ParentId != categories[i-1].ParentId)
                        c.level++;
                }                
            }

            return categories;
        }

        public Task<List<CategoryViewDataModel>> FindWithChildrenAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

