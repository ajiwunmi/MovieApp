using ReactMovieApp.Models;

namespace ReactMovieApp.Services
{
    public interface IMovieSearchService
    {
       
        void SaveMovieSearched();

        void UpdateMovieSearched(int limit);

        void DeleteMovieSearched(int limit);

        List<Movie> GetLatestMovieSearched(int limit);
    }
}

