
using ReactMovieApp.Models;

namespace ReactMovieApp.Services
{
    public interface IMovieService
    {

        Task<IEnumerable<MovieResponseModel>> SearchMoviesAsync(string title);

        Task<Movie> GetMovieDetailsAsync(int id);

        //Task<Movie> GetMovieByIdAsync(int id);
     


    }
}
