namespace Domain.Models.Anime.Entities
{
    public class AnimePosterImage
    {
        public int Id { get; init; } 
        public string AnimeId { get; init; } = string.Empty;
        public string Tiny { get; init; } = string.Empty;
        public string Small { get; init; } = string.Empty;
        public string Medium { get; init; } = string.Empty;
        public string Large { get; init; } = string.Empty;
        public string Original { get; init; } = string.Empty;

        public virtual AnimeData AnimeData { get; init; } = null!;
    }
}
