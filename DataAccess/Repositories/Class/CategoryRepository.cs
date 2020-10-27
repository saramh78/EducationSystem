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

        public async Task<List<CategoryViewDataModel>> FindWithChildrenAsync(int id)
        {
            //var category = await _context.Set<Category>()
            //    .Include(x => x.Children).FirstOrDefaultAsync(x => x.Id.Equals(id);



            var students = await _context.Set<CategoryViewDataModel>().FromSqlRaw("GetCategories1 {0},{1}", id,2).ToListAsync();
            //var ff = students.GroupBy(x => x.ParentId);
            return students;

        //var category = _context.Set<Category>().FromSqlRaw("");



            //var category = await (from c1 in _context.Set<Category>()
            //                join c2 in _context.Set<Category>() on c1.Id equals c2.ParentId
            //                join co in _context.Set<Course>() on c1.Id equals co.CategoryId
            //                where c1.Id.Equals(id) 
            //                select c1).FirstOrDefaultAsync();
            //return category;


          
           //List<Category> hierarchy = new List<Category>();
            //Category category =await _context.Set<Category>().FirstOrDefaultAsync(x => x.Id.Equals(id));
            //hierarchy.Add(category);
            //hierarchy.AddRange(categories
            //                .Where(c => c.ParentId == id)
            //                .Select(c => new Category()
            //                {
            //                    Id = c.Id,
            //                    Name=c.Name,
            //                    ParentId = c.ParentId,
            //                    Courses=c.Courses,
            //                    Children = GetChildren( categories,c.Id)
            //                })
            //                .ToList());
            //return hierarchy; List<Category> categories =await _context.Set<Category>().ToListAsync();

        }

    public static List<Category> GetChildren(List<Category> categories, int parentId)
    {
            return null;
      //  return categories
            //return categories.Where(x => x.ParentId == parentId || x.Id == parentId)
            //   .Union(categories.Where(x => x.ParentId == parentId)
            //               .SelectMany(y => GetChildren(y.Id)));

        //List<Category> a=categories.Where(c => c.ParentId == parentId)
        //        .Select(c => new Category
        //        {
        //            Id = c.Id,
        //            Name = c.Name,
        //            ParentId = c.ParentId,
        //            Courses = c.Courses,
        //            Children = GetChildren(categories, c.Id)
        //        })
        //        .ToList();
        //return a;

    }
}
}

