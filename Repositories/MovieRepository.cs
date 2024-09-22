using ReactMovieApp.Models;
using ReactMovieApp.Repositories;
using ReactMovieApp.Data;

namespace ReactMovieApp.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task SaveLatestSearchAsync(Movie movie)
        {
            // Save movie to the database and keep the latest 5
        }
    }
}


