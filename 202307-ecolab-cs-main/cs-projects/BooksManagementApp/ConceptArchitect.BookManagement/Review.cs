﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public class Review
    {
        public string Id { get; set; }

        public User user { get; set; }

        public User book { get; set; }

        public string Rating { get; set; }

        public string Title { get; set; }
        public string Details { get; set; }
    }
}
