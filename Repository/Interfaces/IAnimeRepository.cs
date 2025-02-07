using Domain.Models.Anime.Entities;

namespace Repository.Interfaces
{
    /// <summary>
    /// The anime repository.
    /// </summary>
    public interface IAnimeRepository
    {
        /// <summary>
        /// Gets all animes.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<AnimeData>> GetAll(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes and inserts animes.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task Upsert(IEnumerable<AnimeData> entities, CancellationToken cancellationToken);
    }

}
