﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class Link : BaseEntity<int>
    {
        public int ArticleId { get; set; }
        public string Url { get; set; }
        public Article Article { get; set; }
        public LinkType LinkType { get; set; }
    }
}
