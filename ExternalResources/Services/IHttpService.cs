using Domain.Models.Anime.Dto;

namespace ExternalResources.Services
{
    /// <summary>
    /// Service that handles Http requests.
    /// </summary>
    public interface IHttpService
    {
        /// <summary>
        /// Gets animes from external repository.
        /// </summary>
        /// <param name="baseUrl">The base Url for the external repository.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<AnimeListDto> GetAnimeList(string baseUrl, CancellationToken cancellationToken);

        /// <summary>
        /// Sends request to the endpoint responsible for deleting and inserting animes.
        /// </summary>
        /// <param name="baseUrl">The base Url for the endpoint.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task UpsertAnimeList(string baseUrl, CancellationToken cancellationToken);
    }
}