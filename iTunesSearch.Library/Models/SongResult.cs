namespace iTunesSearch.Library.Models;

public class SongResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<Song>? Songs { get; set; }
}
