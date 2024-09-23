using ReactMovieApp.Models;
using ReactMovieApp.Repositories;
using ReactMovieApp.Data;

namespace ReactMovieApp.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Movie> GetMovieQueryByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<IEnumerable<Movie>> GetLatestMovieQueriesAsync(int count = 5)
        {
            return await _context.Movies
                .OrderByDescending(q => q.QueryTime)
                .Take(count)
                .ToListAsync();
        }

        public async Task AddMovieQueryAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}




  

