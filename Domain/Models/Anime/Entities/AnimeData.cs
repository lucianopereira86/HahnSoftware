using Domain.Models.Anime.Dto;

namespace Domain.Models.Anime.Entities
{
    public class AnimeData
    {
        public string Id { get; set; } = string.Empty;  
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AnimeTitle Title { get; set; } = new();
        public AnimePosterImage PosterImage { get; set; } = new();
        public string Slug { get; set; } = string.Empty;
        public string Synopsis { get; set; } = string.Empty;
        public string CanonicalTitle { get; set; } = string.Empty;
        public string[] AbbreviatedTitles { get; set; } = [];
        public string AverageRating { get; set; } = string.Empty;
        public int UserCount { get; set; }
        public int FavoritesCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PopularityRank { get; set; }
        public int RatingRank { get; set; }
        public string AgeRatingGuide { get; set; } = string.Empty;
        public int EpisodeCount { get; set; }
        public int? EpisodeLength { get; set; }
        public string YoutubeVideoId { get; set; } = string.Empty;
        public bool Nsfw { get; set; }
    }
}
