using Domain.Models.Anime.Entities;

namespace Repository.Interfaces
{
    public interface IAnimeRepository
    {
        Task<IEnumerable<AnimeData>> GetAll(CancellationToken cancellationToken);

        Task Upsert(IEnumerable<AnimeData> entities, CancellationToken cancellationToken);
    }

}
