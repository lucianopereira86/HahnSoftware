namespace Domain.Models.Anime.Entities
{
    public class AnimePosterImage
    {
        public int Id { get; set; } 
        public string AnimeId { get; set; } = string.Empty;
        public string Tiny { get; set; } = string.Empty;
        public string Small { get; set; } = string.Empty;
        public string Medium { get; set; } = string.Empty;
        public string Large { get; set; } = string.Empty;
        public string Original { get; set; } = string.Empty;

        public virtual AnimeData AnimeData { get; set; } = new();
    }
}
