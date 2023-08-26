using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConceptArchitect.BookManagement
{
    public class Book
    {
        [UniqueBookId]
        public string Id { get; set; }

        public string Title { get; set; }

        [WordCount(10)]
        [Required]
        [StringLength(2000, MinimumLength = 10)]
        public string Description { get; set; }

        [ExistingAuthor]
        public string AuthorId { get; set; }

        public string CoverPhoto { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<Favorite> Favorites { get; set; } = new List<Favorite>();

        public override string ToString()
        {
            return $"Book[Id={Id} , Title={Title} ]";
        }
    }
}
