using ReactMovieApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace ReactMovieApp.Repositories
{
    public interface IMovieSearchRepository
    {
        Task SaveQueryAsync(string query);
        Task<List<string>> GetLatestQueriesAsync(int count);

        List<MovieSearch> GetAll();
    }
}


