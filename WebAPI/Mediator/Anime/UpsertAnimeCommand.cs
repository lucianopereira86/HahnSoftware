using MediatR;

namespace WebAPI.Mediator.Anime
{
    public class UpsertAnimeCommand : IRequest
    {
        public string BaseUrl { get; set; } = string.Empty;
    }
}
