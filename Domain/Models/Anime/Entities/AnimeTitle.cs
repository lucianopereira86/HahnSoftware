namespace Domain.Models.Anime.Entities
{
    /// <summary>
    /// The anime titles for different languages.
    /// </summary>
    public class AnimeTitle
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
        /// The title in English.
        /// </summary>
        public string En { get; init; } = string.Empty;

        /// <summary>
        /// The title in Japanese.
        /// </summary>
        public string Ja_jp { get; init; } = string.Empty;

        public virtual AnimeData AnimeData { get; init; } = null!;
    }
}
