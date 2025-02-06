namespace Domain.Models.Anime.Entities
{
    public class AnimeTitle
    {
        public int Id { get; init; }
        public string AnimeId { get; init; } = string.Empty;
        public string En { get; init; } = string.Empty;
        public string En_jp { get; init; } = string.Empty;
        public string Ja_jp { get; init; } = string.Empty;

        public virtual AnimeData AnimeData { get; init; } = null!;
    }
}
