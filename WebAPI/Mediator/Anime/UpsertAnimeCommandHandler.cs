using Domain.Models.Anime.Entities;
using Domain.Models.Anime.Response;
using ExternalResources.Services;
using MediatR;
using Repository.Interfaces;

namespace WebAPI.Mediator.Anime
{
    public class UpsertAnimeCommandHandler : IRequestHandler<UpsertAnimeCommand>
    {
        private readonly ILogger<UpsertAnimeCommandHandler> _logger;
        private readonly IAnimeRepository _animeRepository;
        private readonly IHttpService _httpService;
        public UpsertAnimeCommandHandler(ILogger<UpsertAnimeCommandHandler> logger, IAnimeRepository animeRepository, IHttpService httpService)
        {
            _logger = logger;
            _animeRepository = animeRepository;
            _httpService = httpService;
        }
        public async Task Handle(UpsertAnimeCommand request, CancellationToken cancellationToken)
        {
            var animeList = await _httpService.GetAnimeList(request.BaseUrl, cancellationToken);
            var entities = MapToEntities(animeList);
            await _animeRepository.Upsert(entities, cancellationToken);
        }

        private static List<AnimeData> MapToEntities(AnimeList animeList)
        {
            var entities = new List<AnimeData>();
            foreach (var anime in animeList.Data)
            {
                entities.Add(new AnimeData
                {
                    AbbreviatedTitles = anime.Attributes.AbbreviatedTitles,
                    AgeRatingGuide = anime.Attributes.AgeRatingGuide,
                    Title = new AnimeTitle
                    {
                        AnimeId = anime.Id,
                        //En = anime.Attributes.Titles.En,
                        //En_jp = anime.Attributes.Titles.En_jp,
                        //Ja_jp = anime.Attributes.Titles.Ja_jp
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
                        //Tiny = anime.Attributes.PosterImage.Tiny,
                        //Small = anime.Attributes.PosterImage.Small,
                        //Large = anime.Attributes.PosterImage.Large,
                        //Original = anime.Attributes.PosterImage.Original
                    },
                    RatingRank = anime.Attributes.RatingRank,
                    Slug = anime.Attributes.Slug,
                    StartDate = anime.Attributes.StartDate,
                    Synopsis = anime.Attributes.Synopsis,
                    UpdatedAt = anime.Attributes.UpdatedAt,
                    UserCount = anime.Attributes.UserCount,
                    YoutubeVideoId = anime.Attributes.YoutubeVideoId
                });
            }
            return entities;
        }
    }
}
