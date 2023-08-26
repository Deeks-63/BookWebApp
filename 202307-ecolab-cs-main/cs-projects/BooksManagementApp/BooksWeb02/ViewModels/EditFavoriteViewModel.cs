using ConceptArchitect.BookManagement;
using DataAnnotationsExtensions;

namespace BooksWeb02.ViewModels
{
    public class EditFavoriteViewModel : Favorite
    {
        public int Id { get; set; }

        [Email]
        [ExistingUser]
        public string UserEmail { get; set; }

        [ExistingBook]
        public string BookId { get; set; }

        public string Status { get; set; } = "Reading";
    }
}
