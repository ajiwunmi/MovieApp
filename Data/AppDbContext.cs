using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Models;
using System.Collections.Generic;


namespace ReactMovieApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}

