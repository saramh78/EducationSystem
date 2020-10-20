using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public Category Parent{ get; set; }
        public ICollection<Category> Children { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
