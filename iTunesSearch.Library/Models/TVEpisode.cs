namespace iTunesSearch.Library.Models;

public partial class TVEpisode
{
    [JsonPropertyName("artistId")]
    public long ShowId { get; set; }

    [JsonPropertyName("collectionId")]
    public long SeasonId { get; set; }

    [JsonPropertyName("trackId")]
    public long EpisodeId { get; set; }

    [JsonPropertyName("artistName")]
    public string? ShowName { get; set; }

    [JsonPropertyName("collectionName")]
    public string? SeasonName { get; set; }

    [JsonPropertyName("trackName")]
    public string? Name { get; set; }

    [JsonPropertyName("collectionCensoredName")]
    public string? SeasonCensoredName { get; set; }

    [JsonPropertyName("trackCensoredName")]
    public string? CensoredName { get; set; }

    [JsonPropertyName("artistViewUrl")]
    public string? ShowViewUrl { get; set; }

    [JsonPropertyName("collectionViewUrl")]
    public string? SeasonViewUrl { get; set; }

    [JsonPropertyName("trackViewUrl")]
    public string? ViewUrl { get; set; }

    [JsonPropertyName("previewUrl")]
    public string? PreviewUrl { get; set; }

    [JsonPropertyName("artworkUrl100")]
    public string? ArtworkUrl { get; set; }

    [JsonPropertyName("collectionPrice")]
    public decimal SeasonPrice { get; set; }

    [JsonPropertyName("trackPrice")]
    public decimal Price { get; set; }

    [JsonPropertyName("collectionHdPrice")]
    public decimal SeasonPriceHD { get; set; }

    [JsonPropertyName("trackHdPrice")]
    public decimal PriceHD { get; set; }

    [JsonPropertyName("releaseDate")]
    public string? ReleaseDate { get; set; }

    [JsonPropertyName("collectionExplicitness")]
    public string? SeasonExplicitness { get; set; }

    [JsonPropertyName("trackExplicitness")]
    public string? Explicitness { get; set; }

    [JsonPropertyName("trackCount")]
    public int SeasonEpisodeCount { get; set; }

    [JsonPropertyName("trackNumber")]
    public int Number { get; set; }

    [JsonPropertyName("trackTimeMillis")]
    public long RuntimeInMilliseconds { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("primaryGenreName")]
    public string? Genre { get; set; }

    [JsonPropertyName("contentAdvisoryRating")]
    public string? Rating { get; set; }

    [JsonPropertyName("shortDescription")]
    public string? DescriptionShort { get; set; }

    [JsonPropertyName("longDescription")]
    public string? DescriptionLong { get; set; }

    /// <summary>
    /// The parsed large artwork url, based on the regular artwork url
    /// </summary>
    public string ArtworkLargeUrl
    {
        get
        {
            string retval = string.Empty;

            if (!string.IsNullOrEmpty(this.ArtworkUrl))
            {
                retval = this.ArtworkUrl.Replace("100x100", "600x600");
            }

            return retval;
        }
    }

    /// <summary>
    /// The parsed season number, based on the season name
    /// </summary>
    public int SeasonNumber
    {
        get
        {
            int retval = 0;

            //  See if we can parse the season number from the season name
            try
            {
                string newString = RegexGenerators.SeasonNumberRegex().Replace(SeasonName!, "");
                retval = Convert.ToInt32(newString);
            }
            catch (Exception)
            { /* Don't do anything */ }

            return retval;
        }
    }
}
