namespace Domain.Models.Anime.Dto
{
    /// <summary>
    /// Contains the list of animes.
    /// </summary>
    public record AnimeListDto
    {
        /// <summary>
        /// List of animes. 
        /// </summary>
        public AnimeListDataDto[] Data { get; init; } = [];
    }
}
