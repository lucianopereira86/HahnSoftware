using Domain.Models.Anime.Entities;
using MediatR;
using Repository.Interfaces;

namespace WebAPI.Mediator.Anime
{
    public class UpsertAnimeQueryHandler : IRequestHandler<UpsertAnimeQuery, IEnumerable<AnimeData>>
    {
        private readonly ILogger<UpsertAnimeQueryHandler> _logger;
        private readonly IAnimeRepository _animeRepository;
        public UpsertAnimeQueryHandler(ILogger<UpsertAnimeQueryHandler> logger, IAnimeRepository animeRepository)
        {
            _logger = logger;
            _animeRepository = animeRepository;
        }
        public async Task<IEnumerable<AnimeData>> Handle(UpsertAnimeQuery request, CancellationToken cancellationToken)
        {
            return await _animeRepository.GetAll(cancellationToken);
        }
    }
}
