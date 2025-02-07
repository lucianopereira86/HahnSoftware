namespace Domain.Models.Anime.Dto
{
    /// <summary>
    /// Contains the anime identifier and attributes.
    /// </summary>
    public record AnimeListDataDto
    {
        /// <summary>
        /// Anime identifier.
        /// </summary>
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// Anime attributes.
        /// </summary>
        public AnimeAttributesDto Attributes { get; init; } = new();
    }
}
