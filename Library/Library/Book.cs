﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        //[Key]
        public int ISBN { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }

        public string Description { get; set; }
        public int? Copies { get; set; }
    }
}
