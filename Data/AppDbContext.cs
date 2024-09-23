using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Models;



namespace ReactMovieApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieSearch> MovieSearches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
            .HasMany(m => m.MovieSearches)
            .WithOne(ms => ms.Movie)
            .HasForeignKey(ms => ms.MovieId);
        }
    }
}



