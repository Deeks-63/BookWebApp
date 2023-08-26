using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement.Repositories.EFRepository
{
    public class EFFavouriteRepository : IRepository<Favourite, int>
    {
        BMSContext context;
        public EFFavouriteRepository(BMSContext context)
        {
            this.context = context;
        }
        public async Task<Favourite> Add(Favourite entity)
        {
            context.Favourites.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var favourite = await GetById(id);
            context.Favourites.Remove(favourite);
            await context.SaveChangesAsync();
        }



        public async Task<List<Favourite>> GetAll()
        {
            await Task.CompletedTask;
            return context.Favourites.ToList();
        }



        public async Task<List<Favourite>> GetAll(Func<Favourite, bool> predicate)
        {
            await Task.CompletedTask;
            var query = from favourite in context.Favourites
                        where predicate(favourite)
                        select favourite;
            return query.ToList();
        }



        public async Task<Favourite> GetById(int id)
        {
            await Task.CompletedTask;
            return context.Favourites.FirstOrDefault(favourite => favourite.Id == id);
        }

        Task<Favourite> IRepository<Favourite, int>.Update(Favourite entity, Action<Favourite, Favourite> mergeOldNew)
        {
            throw new NotImplementedException();
        }
    }
}
