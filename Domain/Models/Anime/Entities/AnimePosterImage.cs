namespace Domain.Models.Anime.Entities
{
    /// <summary>
    /// The anime poster image Urls for different sizes.
    /// </summary>
    public class AnimePosterImage
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

        public virtual AnimeData AnimeData { get; init; } = null!;
    }
}
