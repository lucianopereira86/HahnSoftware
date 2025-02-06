namespace Domain.Models.Anime.Response
{
    public class AnimeList
    {
        public AnimeListData[] Data { get; init; } = [];
        public AnimeListMeta Meta { get; init; } = new();
    }
}
