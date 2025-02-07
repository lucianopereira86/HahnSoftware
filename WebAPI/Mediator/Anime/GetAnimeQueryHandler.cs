using Domain.Models.Anime.Entities;
using MediatR;
using Repository.Interfaces;

namespace WebAPI.Mediator.Anime
{
    /// <summary>
    /// Represents a query handler that returns the anime list.
    /// </summary>
    public class GetAnimeQueryHandler : IRequestHandler<GetAnimeQuery, IEnumerable<AnimeData>>
    {
        private readonly ILogger<GetAnimeQueryHandler> _logger;
        private readonly IAnimeRepository _animeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimeQueryHandler"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="animeRepository">The anime repository.</param>
        public GetAnimeQueryHandler(ILogger<GetAnimeQueryHandler> logger, IAnimeRepository animeRepository)
        {
            _logger = logger;
            _animeRepository = animeRepository;
        }

        /// <summary>
        /// Receives a query and returns a result.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<AnimeData>> Handle(GetAnimeQuery query, CancellationToken cancellationToken)
        {
            return await _animeRepository.GetAll(cancellationToken);
        }
    }
}
