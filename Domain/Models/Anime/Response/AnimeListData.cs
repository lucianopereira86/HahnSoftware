using Domain.Models.Anime.Dto;

namespace Domain.Models.Anime.Response
{
    public class AnimeListData
    {
        public string Id { get; init; } = string.Empty;
        public AnimeAttributesDto Attributes { get; init; } = new();
    }
}
