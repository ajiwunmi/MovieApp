using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Models;

namespace ReactMovieApp.Repositories
{
    public interface IMovieRepository
    {
      
        public Task<Movie> GetMovieByIdAsync(int id);

        public Task SaveLatestSearchAsync(Movie movie);
       

    }
}
