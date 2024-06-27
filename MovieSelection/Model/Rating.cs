using System.Text.Json.Serialization;

namespace MovieSelection.Model;

public class Rating
{
    [JsonPropertyName("kp")]
    public float KP { get; set; }
    [JsonPropertyName("imdb")]
    public float IMDB { get; set; }
}