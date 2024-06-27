using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieSelection.Model;

[Table("Movie")]
public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int Year { get; set; }
    public double RatingKP { get; set; }
    public int AgeRating { get; set; }
    public int? MovieLength { get; set; }
    public int? SeriesLength { get; set; }
    public string PreviewUrl { get; set; }

    public List<Genre> Genres { get; set; } = new();
    //public List<GenresMovies> GenresMovies { get; set; }
}