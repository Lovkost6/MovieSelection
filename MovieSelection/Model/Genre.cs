using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieSelection.Model;

[Table("Genre")]
public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Movie> Movies  { get; set; } = new();

    //public List<GenresMovies> GenresMovies { get; set; }
}