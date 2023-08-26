using ConceptArchitect.BookManagement;

namespace BooksWeb02.ViewModels
{
    public class EditReview_ViewModel : Review
    {
        public int Id { get; set; }

        [ExistingUser]
        public string UserEmail { get; set; }

        [ExistingBook]
        public string bookId { get; set; }

        public string Rating { get; set; }

        public string? Title { get; set; }
        public string? Details { get; set; }

    }
}
