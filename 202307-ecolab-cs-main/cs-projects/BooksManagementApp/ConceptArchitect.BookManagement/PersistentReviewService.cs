using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
   
        public class PersistentReviewService : IReviewService
        {
            IRepository<Review, int> repository;

            public PersistentReviewService(IRepository<Review, int> reviewRepository)
            {
                this.repository = reviewRepository;
            }


            public async Task<Review> AddReview(Review review)
            {
                if (review == null)
                {
                    throw new InvalidDataException("Review can't be null");
                }

               
                return await repository.Add(review);
            }
            public async Task<List<Review>> GetReviewsByBookId(string bookid)
            {
                 return await repository.GetAll(r => r.BookId == bookid);
            }

            public Task<Review> GetById(int id)
            {
            return repository.GetById(id);
             }
        public async Task<List<Review>> GetAllReviews()
            {
                return await repository.GetAll();
            }

        
           
        }
    }

