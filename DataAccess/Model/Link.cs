using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    class Link
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public LinkType LinkType { get; set; }
    }
}
