namespace iTunesSearch.Library.Models;

public class TVEpisodeListResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<TVEpisode>? Episodes { get; set; }
}
