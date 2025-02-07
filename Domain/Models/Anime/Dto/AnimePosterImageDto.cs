namespace Domain.Models.Anime.Dto
{
    /// <summary>
    /// The anime poster image Urls for different sizes.
    /// </summary>
    public record AnimePosterImageDto
    {
        /// <summary>
        /// The Url for tiny size.
        /// </summary>
        public string Tiny { get; init; } = string.Empty;

        /// <summary>
        /// The Url for small size.
        /// </summary>
        public string Small { get; init; } = string.Empty;

        /// <summary>
        /// The Url for medium size.
        /// </summary>
        public string Medium { get; init; } = string.Empty;

        /// <summary>
        /// The Url for large size.
        /// </summary>
        public string Large { get; init; } = string.Empty;

        /// <summary>
        /// The Url for original size.
        /// </summary>
        public string Original { get; init; } = string.Empty;
    }
}
