namespace iTunesSearch.Library.Models;

public class PodcastListResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<Podcast>? Podcasts { get; set; }
}