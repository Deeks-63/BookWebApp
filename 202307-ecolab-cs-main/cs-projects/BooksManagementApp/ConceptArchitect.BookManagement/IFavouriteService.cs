using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public interface IFavouriteService
    {

        
            Task<Favourite> AddFavourite(Favourite favourite);

        Task<Favourite> UpdateFavourite(Favourite favourite);
        Task<Favourite> GetById(int id);
        Task<List<Favourite>> GetFavouriteByUserId(string userEmail);

        Task DeleteFavourite(int id);






    }
}
