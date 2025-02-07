using Domain.Models.Anime.Entities;
using MediatR;
using Repository.Interfaces;

namespace WebAPI.Mediator.Anime
{
    public class GetAnimeQueryHandler : IRequestHandler<GetAnimeQuery, IEnumerable<AnimeData>>
    {
        private readonly ILogger<GetAnimeQueryHandler> _logger;
        private readonly IAnimeRepository _animeRepository;
        public GetAnimeQueryHandler(ILogger<GetAnimeQueryHandler> logger, IAnimeRepository animeRepository)
        {
            _logger = logger;
            _animeRepository = animeRepository;
        }
        public async Task<IEnumerable<AnimeData>> Handle(GetAnimeQuery request, CancellationToken cancellationToken)
        {
            return await _animeRepository.GetAll(cancellationToken);
        }
    }
}
