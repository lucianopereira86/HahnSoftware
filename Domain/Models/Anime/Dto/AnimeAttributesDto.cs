namespace Domain.Models.Anime.Dto
{
    /// <summary>
    /// Contains the anime attributes.
    /// </summary>
    public record AnimeAttributesDto
    {
        /// <summary>
        /// Created at (ISO 8601 date and time).
        /// </summary>
        public DateTime CreatedAt { get; init; }

        /// <summary>
        /// Updated at (ISO 8601 date and time).
        /// </summary>
        public DateTime UpdatedAt { get; init; }

        /// <summary>
        /// Slug (e.g.: cowboy-bebop).
        /// </summary>
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Synopsis (e.g.: In the year 2071, humanity has colonoized several of the planets and moons...).
        /// </summary>
        public string Synopsis { get; init; } = string.Empty;

        /// <summary>
        /// Titles in different languages.
        /// </summary>
        public AnimeTitleDto Titles { get; init; } = new();

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
        /// Poster image Urls for different sizes.
        /// </summary>
        public AnimePosterImageDto PosterImage { get; init; } = new();

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
