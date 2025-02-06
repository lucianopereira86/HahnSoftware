namespace Domain.Models.Anime.Entities
{
    public class AnimeTitle
    {
        public int Id { get; set; }
        public string AnimeId { get; set; } = string.Empty;
        public string En { get; set; } = string.Empty;
        public string En_jp { get; set; } = string.Empty;
        public string Ja_jp { get; set; } = string.Empty;

        public virtual AnimeData AnimeData { get; set; } = new();
    }
}
