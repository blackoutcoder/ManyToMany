﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Book
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public List<Page> Pages { get; set; }
        public List<Category> Categories { get; set; }
    }
}
