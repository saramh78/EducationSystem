using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class Category : BaseEntity<int>
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public Category Parent{ get; set; }
        public ICollection<Category> Children { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
