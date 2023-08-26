using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public class User
    {
        [Email]
        [Key]
        public string Email { get; set; }   
        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Column("PhotoUrl")]
        public string? ProfilePhoto { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<Favorite> Favorites { get; set; } = new List<Favorite>();


    }
}
