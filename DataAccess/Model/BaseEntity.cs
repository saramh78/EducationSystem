﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
