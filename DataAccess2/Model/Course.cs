using System.Collections.Generic;

namespace DataAccess.Model
{
    public class Course : BaseEntity<int>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public ICollection<CoursePart> CourseParts { get; set; }
    }
}
