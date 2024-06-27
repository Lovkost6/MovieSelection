using Microsoft.EntityFrameworkCore;
using MovieSelection.Model;

namespace MovieSelection.Data;

public class ApplicationContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres{ get; set; }
    //public DbSet<GenresMovies> GenresMovies{ get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<GenresMovies>(entity => { entity.HasKey(e => new { e.MovieId, e.GenreId }); });
    }
}