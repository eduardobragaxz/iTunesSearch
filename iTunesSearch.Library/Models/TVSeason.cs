namespace iTunesSearch.Library.Models;

public partial class TVSeason
{
    [JsonPropertyName("artistId")]
    public long ShowId { get; set; }

    [JsonPropertyName("collectionId")]
    public long SeasonId { get; set; }

    [JsonPropertyName("artistName")]
    public string? ShowName { get; set; }

    [JsonPropertyName("collectionName")]
    public string? SeasonName { get; set; }

    [JsonPropertyName("collectionCensoredName")]
    public string? SeasonCensoredName { get; set; }

    [JsonPropertyName("artistViewUrl")]
    public string? ShowViewUrl { get; set; }

    [JsonPropertyName("collectionViewUrl")]
    public string? SeasonViewUrl { get; set; }

    [JsonPropertyName("artworkUrl100")]
    public string? ArtworkUrl { get; set; }

    [JsonPropertyName("collectionPrice")]
    public decimal SeasonPrice { get; set; }

    [JsonPropertyName("collectionHdPrice")]
    public decimal SeasonPriceHD { get; set; }

    [JsonPropertyName("releaseDate")]
    public string? ReleaseDate { get; set; }

    [JsonPropertyName("collectionExplicitness")]
    public string? SeasonExplicitness { get; set; }

    [JsonPropertyName("trackCount")]
    public int SeasonEpisodeCount { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("primaryGenreName")]
    public string? Genre { get; set; }

    [JsonPropertyName("contentAdvisoryRating")]
    public string? Rating { get; set; }

    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    [JsonPropertyName("longDescription")]
    public string? Description { get; set; }

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
            catch(Exception)
            { /* Don't do anything */ }

            return retval;
        }
    }

    /// <summary>
    /// The parsed 'large' artwork url
    /// </summary>
    public string ArtworkUrlLarge
    {
        get 
        {
            string retval = string.Empty;

            //  See if we can parse the large artwork url from the regular artwork url
            try
            {
                retval = ArtworkUrl!.Replace("100x100", "600x600");
            }
            catch(Exception)
            { }

            return retval;
        }
    }
}
