using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    class CategoryParsed
    {
        public Category Categ { get; set; }
        public int level { get; set; }
        public bool Parsed { get; set; }

    }
}
