using ReactMovieApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace ReactMovieApp.Repositories
{
    public interface IMovieSearchRepository : IDisposable
    {
       // List<MovieSearch> GetAll();

        //Task<MovieSearch> GetMovieQueryByTitleAsync(string title);
        Task<IEnumerable<MovieSearch>> GetLatestMovieQueriesAsync(int count = 5);
        Task<List<MovieSearch>> GetLatestSearchesAsync(int count);
        Task AddMovieQueryAsync(MovieSearch movieQuery);
        Task SaveChangesAsync();
    }
}


