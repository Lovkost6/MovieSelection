using System.Text.Json.Serialization;

namespace MovieSelection.Model;

public class Poster
{
    [JsonPropertyName("previewUrl")]
    public string Url { get; set; }
}