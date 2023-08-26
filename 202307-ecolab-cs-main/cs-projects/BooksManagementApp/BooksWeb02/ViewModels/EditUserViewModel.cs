using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ConceptArchitect.BookManagement;

namespace BooksWeb02.ViewModels
{
    public class EditUserViewModel : User
    {
        [Email]
        public string Email { get; set; }
    
        public string Password { get; set; }

        public string Name { get; set; }

        public string? ProfilePhoto { get; set; }
    }
}
