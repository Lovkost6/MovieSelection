using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSelection.Model;

[Table("GenreMovie")]
public class GenresMovies
{
    public Movie Movie { get; set; }
    public int MoviesId { get; set; }
    public int GenresId { get; set; }
}