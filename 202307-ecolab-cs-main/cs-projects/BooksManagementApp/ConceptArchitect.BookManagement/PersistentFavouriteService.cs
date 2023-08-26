using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
   public class PersistentFavouriteService : IFavouriteService
    {
        IRepository<Favourite, int> repository;
        public PersistentFavouriteService(IRepository<Favourite, int> repository)
        {
            this.repository = repository;
        }
        public async Task<Favourite> AddFavourite(Favourite favourite)
        {
            if (favourite == null)
            {
                throw new InvalidDataException("Favourite cannot be null");
            }
            /*if (string.IsNullOrEmpty(favourite.Id.ToString()))
            {
                favourite.Id = await GenerateFavouriteId();
            }*/
            return await repository.Add(favourite);
        }
        public async Task DeleteFavourite(int id)
        {
            await repository.Delete(id);
        }
        public Task<Favourite> GetById(int id)
        {
            return repository.GetById(id);
        }
        public async Task<List<Favourite>> GetFavouriteByUserId(string userEmail)
        {
            return await repository.GetAll(r => r.UserEmail == userEmail);
        }

        public async Task<Favourite> UpdateFavourite(Favourite favourite)
        {
            return await repository.Update(favourite, (old, newDetails) =>
            {
                old.Id = newDetails.Id;
                old.UserEmail = newDetails.UserEmail;
                old.Status = newDetails.Status;
                old.BookId = newDetails.BookId;
            });
        }

    }
}
