using MediatR;

namespace WebAPI.Mediator.Anime
{
    public class UpsertAnimeCommand : IRequest
    {
        public string BaseUrl { get; init; } = string.Empty;
    }
}
