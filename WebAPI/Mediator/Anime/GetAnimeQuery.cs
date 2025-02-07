using Domain.Models.Anime.Entities;
using MediatR;

namespace WebAPI.Mediator.Anime
{
    public class GetAnimeQuery : IRequest<IEnumerable<AnimeData>>
    {
        
    }
}
