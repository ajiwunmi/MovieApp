using ReactMovieApp.Models;

namespace ReactMovieApp.Repositories
{
    public class MovieSearchRepository : IMovieSearchRepository 
    {
        private readonly IMovieRepository _movieRepository;
        public MovieSearchRepository(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovieSearch(MovieSearch movieSearch)
        {
            //Code here
        }

        public MovieSearch GetMovieSearch(int id)
        {
            //code here
        }

        public List<MovieSearch> GetAll()
        {
            //code here
        }
    }
}
