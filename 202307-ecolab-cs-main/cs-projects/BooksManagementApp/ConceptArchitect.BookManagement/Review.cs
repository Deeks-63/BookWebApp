using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public class Review
    {
        public int Id { get; set; }

        [ExistingAuthor]
       public string BookId { get; set; }
        public string UserEmail { get; set; }

        public string Rating { get; set; }

        public string Title { get; set; }
        public string Details { get; set; }
    }
}
