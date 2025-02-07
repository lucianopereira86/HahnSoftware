using Domain.Models.Anime.Dto;
using Domain.Models.Anime.Entities;
using ExternalResources.Services;
using MediatR;
using Repository.Interfaces;

namespace WebAPI.Mediator.Anime
{
    /// <summary>
    /// Represents a command handler that searches for animes from external repository and inserts them into database.
    /// </summary>
    public class UpsertAnimeCommandHandler : IRequestHandler<UpsertAnimeCommand>
    {
        private readonly ILogger<UpsertAnimeCommandHandler> _logger;
        private readonly IAnimeRepository _animeRepository;
        private readonly IHttpService _httpService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertAnimeCommandHandler"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="animeRepository">The anime repository.</param>
        /// <param name="httpService">The Http service.</param>
        public UpsertAnimeCommandHandler(ILogger<UpsertAnimeCommandHandler> logger, IAnimeRepository animeRepository, IHttpService httpService)
        {
            _logger = logger;
            _animeRepository = animeRepository;
            _httpService = httpService;
        }

        /// <summary>
        /// Receives a command and returns a result.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task Handle(UpsertAnimeCommand command, CancellationToken cancellationToken)
        {
            var animeList = await _httpService.GetAnimeList(command.BaseUrl, cancellationToken);
            var entities = MapToEntities(animeList);
            await _animeRepository.Upsert(entities, cancellationToken);
        }

        private static IEnumerable<AnimeData> MapToEntities(AnimeListDto animeList)
        {
            return animeList.Data.Select(anime => new AnimeData
            {
                AnimeId = anime.Id,
                AbbreviatedTitles = anime.Attributes.AbbreviatedTitles,
                AgeRatingGuide = anime.Attributes.AgeRatingGuide,
                Title = new AnimeTitle
                {
                    AnimeId = anime.Id,
                    En = anime.Attributes.Titles.En,
                    Ja_jp = anime.Attributes.Titles.Ja_jp
                },
                AverageRating = anime.Attributes.AverageRating,
                CanonicalTitle = anime.Attributes.CanonicalTitle,
                CreatedAt = anime.Attributes.CreatedAt,
                EndDate = anime.Attributes.EndDate,
                EpisodeCount = anime.Attributes.EpisodeCount,
                EpisodeLength = anime.Attributes.EpisodeLength,
                FavoritesCount = anime.Attributes.FavoritesCount,
                Nsfw = anime.Attributes.Nsfw,
                PopularityRank = anime.Attributes.PopularityRank,
                PosterImage = new AnimePosterImage
                {
                    AnimeId = anime.Id,
                    Tiny = anime.Attributes.PosterImage.Tiny,
                    Small = anime.Attributes.PosterImage.Small,
                    Medium = anime.Attributes.PosterImage.Medium,
                    Large = anime.Attributes.PosterImage.Large,
                    Original = anime.Attributes.PosterImage.Original
                },
                RatingRank = anime.Attributes.RatingRank,
                Slug = anime.Attributes.Slug,
                StartDate = anime.Attributes.StartDate,
                Synopsis = anime.Attributes.Synopsis,
                UpdatedAt = anime.Attributes.UpdatedAt,
                UserCount = anime.Attributes.UserCount
            });
        }
    }
}
