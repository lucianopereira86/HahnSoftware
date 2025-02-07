namespace Domain.Models.Anime.Dto
{
    /// <summary>
    /// The anime titles for different languages.
    /// </summary>
    public record AnimeTitleDto
    {
        /// <summary>
        /// The title in English.
        /// </summary>
        public string En { get; init; } = string.Empty;

        /// <summary>
        /// The title in Japanese.
        /// </summary>
        public string Ja_jp { get; init; } = string.Empty;
    }
}
