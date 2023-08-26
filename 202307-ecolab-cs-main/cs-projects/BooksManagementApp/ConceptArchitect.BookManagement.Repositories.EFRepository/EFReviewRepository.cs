using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement.Repositories.EFRepository
{
    public class EFReviewRepository : IRepository<Review, int>
    {
        BMSContext context;
        public EFReviewRepository(BMSContext context)
        {
            this.context = context;
        }
        public async Task<Review> Add(Review entity)
        {
            context.Reviews.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        /*public async Task Delete(string id)
        {
            var review = await GetById(id);
            context.Reviews.Remove(review);
            await context.SaveChangesAsync();
        }*/

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Review>> GetAll()
        {
            await Task.CompletedTask;
            return context.Reviews.ToList();
        }

        public async Task<List<Review>> GetAll(Func<Review, bool> predicate)
        {
            await Task.CompletedTask;
            var q = from review in context.Reviews
                    where predicate(review)
                    select review;
            return q.ToList();
        }

         public async Task<Review> GetReviewsByBookId(string bookid)
         {
             await Task.CompletedTask;
             return context.Reviews.FirstOrDefault(a => a.BookId == bookid);
         }
        
        public  async Task<Review> GetById(int id)
        {
            await Task.CompletedTask;
            return context.Reviews.FirstOrDefault(r => r.Id == id);
        }

        public Task<Review> Update(Review entity, Action<Review, Review> mergeOldNew)
        {
            throw new NotImplementedException();
        }

        /* public async Task<Review> Update(Review entity, Action<Review, Review> mergeOldNew)
         {
             var review = await GetById(entity.Id);
             if (review != null)
             {
                 mergeOldNew(author, entity);
                 await context.SaveChangesAsync();
             }

             return author;
         }*/
    }
}
