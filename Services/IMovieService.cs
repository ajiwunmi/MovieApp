
using ReactMovieApp.Models;

namespace ReactMovieApp.Services
{
    public interface IMovieService
    {

        Task<IEnumerable<Movie>> SearchMoviesAsync(string title);

        Task<Movie> GetMovieDetailsAsync(int id);


    }
}
