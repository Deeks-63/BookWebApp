using ConceptArchitect.BookManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BooksWeb02.Controllers
{
    public class FavoriteController : Controller
    {
        IFavoriteService favoriteService;
        IBookService bookService;

        public FavoriteController(IFavoriteService favoriteService, IBookService bookService)
        {
            this.favoriteService = favoriteService;
            this.bookService = bookService;
        }

        public async Task<ViewResult> Index(User user)
        {
            var favorites = await favoriteService.GetFavoriteByUserId(user.Email);
            List<Book> books = new List<Book>();
            foreach (var favorite in favorites) 
            {
                var book = await bookService.GetBookById(favorite.BookId);
                books.Add(book);
            }
            ViewBag.Bookmarks = books;


            return View(favorites);
        }
    }
}
