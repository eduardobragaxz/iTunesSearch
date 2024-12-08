namespace iTunesSearch.Library.Models;

public class TVSeasonListResult
{
    [JsonPropertyName("resultCount")]
    public int Count { get; set; }

    [JsonPropertyName("results")]
    public List<TVSeason>? Seasons { get; set; }
}
