using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Data;
using ReactMovieApp.Models;

namespace ReactMovieApp.Repositories
{
    public class MovieSearchRepository : IMovieSearchRepository 
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;
        public MovieSearchRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<MovieSearch>> GetLatestMovieQueriesAsync(int count = 5)
        {
            return await _context.MovieSearches
                .OrderByDescending(q => q.SearchTime)
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<MovieSearch>> GetLatestSearchesAsync(int count=5)
        {
            return await _context.MovieSearches
                                 .OrderByDescending(ms => ms.SearchTime)
                                 .Take(count)
                                 .Include(ms => ms.Movie)
                                 .ToListAsync();
        }

        public async Task AddMovieQueryAsync(MovieSearch movieQuery)
        {
            await _context.MovieSearches.AddAsync(movieQuery);
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







