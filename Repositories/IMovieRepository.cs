using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Models;

namespace ReactMovieApp.Repositories
{
    public interface IMovieRepository : IDisposable
    {
        Task<Movie> GetMovieQueryByTitleAsync(int id);
        Task<IEnumerable<Movie>> GetLatestMovieQueriesAsync(int count = 5);
        Task AddMovieQueryAsync(Movie movie);
        Task SaveChangesAsync();
    }

}
