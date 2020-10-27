using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ViewDataModel
{
    public class CategoryViewDataModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryParentId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
