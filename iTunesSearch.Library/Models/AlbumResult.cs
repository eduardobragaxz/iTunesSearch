namespace iTunesSearch.Library.Models;

public class AlbumResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<Album>? Albums { get; set; }
}
