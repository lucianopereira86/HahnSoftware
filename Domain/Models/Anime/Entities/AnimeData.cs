namespace Domain.Models.Anime.Entities
{
    /// <summary>
    /// The anime attributes.
    /// </summary>
    public class AnimeData
    {
        /// <summary>
        /// The auto-generated identifier.
        /// </summary>
        public int Id { get; init; }   

        /// <summary>
        /// The anime identifier.
        /// </summary>
        public string AnimeId { get; init; } = string.Empty;

        /// <summary>
        /// Created at (ISO 8601 date and time).
        /// </summary>
        public DateTime CreatedAt { get; init; }

        /// <summary>
        /// Updated at (ISO 8601 date and time).
        /// </summary>
        public DateTime UpdatedAt { get; init; }

        /// <summary>
        /// Title in different languages.
        /// </summary>
        public AnimeTitle Title { get; init; } = new();

        /// <summary>
        /// Poster image Urls for different sizes.
        /// </summary>
        public AnimePosterImage PosterImage { get; init; } = new();

        /// <summary>
        /// Slug (e.g.: cowboy-bebop).
        /// </summary>
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Synopsis (e.g.: In the year 2071, humanity has colonoized several of the planets and moons...).
        /// </summary>
        public string Synopsis { get; init; } = string.Empty;

        /// <summary>
        /// Canonical title (e.g.: Cowboy Bebop).
        /// </summary>
        public string CanonicalTitle { get; init; } = string.Empty;

        /// <summary>
        /// Abbreviated titles.
        /// </summary>
        public string[] AbbreviatedTitles { get; init; } = [];

        /// <summary>
        /// Average rating.
        /// </summary>
        public string AverageRating { get; init; } = string.Empty;

        /// <summary>
        /// User count.
        /// </summary>
        public int UserCount { get; init; }

        /// <summary>
        /// Favorites count.
        /// </summary>
        public int FavoritesCount { get; init; }

        /// <summary>
        /// Start data (YYYY-MM-DD date).
        /// </summary>
        public DateTime StartDate { get; init; }

        /// <summary>
        /// End data (YYYY-MM-DD date).
        /// </summary>
        public DateTime EndDate { get; init; }

        /// <summary>
        /// Popularity rank.
        /// </summary>
        public int PopularityRank { get; init; }

        /// <summary>
        /// Rating rank.
        /// </summary>
        public int RatingRank { get; init; }

        /// <summary>
        /// Age rating guide (e.g.: 17+ (violence & profanity)).
        /// </summary>
        public string AgeRatingGuide { get; init; } = string.Empty;

        /// <summary>
        /// Episode count.
        /// </summary>
        public int EpisodeCount { get; init; }

        /// <summary>
        /// Episode length.
        /// </summary>
        public int? EpisodeLength { get; init; }

        /// <summary>
        /// Indicates if it's NSFW (Not Safe For Work).
        /// </summary>
        public bool Nsfw { get; init; }
    }
}
