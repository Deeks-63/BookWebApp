using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public interface IReviewService
    {
        Task<List<Review>> GetAllReviews();
        Task<Review> GetById(int id);

        Task<Review> AddReview(Review review);

        Task<List<Review>> GetReviewsByBookId(string bookid);
      /*  Task DeleteReview(string reviewId);*/
    }
}
