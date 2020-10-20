using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public ICollection<CoursePart> CourseParts { get; set; }
    }
}
