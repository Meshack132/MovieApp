using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding initial movie data
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16) },
                new Movie { Id = 2, Title = "The Godfather", Genre = "Crime", ReleaseDate = new DateTime(1972, 3, 24) },
                new Movie { Id = 3, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18) },
                new Movie { Id = 4, Title = "Pulp Fiction", Genre = "Drama", ReleaseDate = new DateTime(1994, 10, 14) }
            );
        }
    }
}
