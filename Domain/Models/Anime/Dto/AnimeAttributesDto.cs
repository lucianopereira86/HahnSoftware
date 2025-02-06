namespace Domain.Models.Anime.Dto
{
    public class AnimeAttributesDto
    {
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
        public string Slug { get; init; } = string.Empty;
        public string Synopsis { get; init; } = string.Empty;
        public AnimeTitleDto Titles { get; init; } = new();
        public string CanonicalTitle { get; init; } = string.Empty;
        public string[] AbbreviatedTitles { get; init; } = [];
        public string AverageRating { get; init; } = string.Empty;
        public int UserCount { get; init; }
        public int FavoritesCount { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public int PopularityRank { get; init; }
        public int RatingRank { get; init; }
        public string AgeRatingGuide { get; init; } = string.Empty;
        public AnimePosterImageDto PosterImage { get; init; } = new();
        public int EpisodeCount { get; init; }
        public int? EpisodeLength { get; init; }
        public string YoutubeVideoId { get; init; } = string.Empty;
        public bool Nsfw { get; init; }
    }
}
