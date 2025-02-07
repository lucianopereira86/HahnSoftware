using MediatR;

namespace WebAPI.Mediator.Anime
{
    /// <summary>
    /// Represents a command for deleting and inserting animes.
    /// </summary>
    public class UpsertAnimeCommand : IRequest
    {
        /// <summary>
        /// The base Url for the external repository.
        /// </summary>
        public string BaseUrl { get; init; } = string.Empty;
    }
}
