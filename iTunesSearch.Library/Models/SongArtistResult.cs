namespace iTunesSearch.Library.Models;

public class SongArtistResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<SongArtist>? Artists { get; set; }
}
