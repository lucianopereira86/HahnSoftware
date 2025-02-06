using Domain.Models.Anime.Entities;
using MediatR;

namespace WebAPI.Mediator.Anime
{
    public class UpsertAnimeQuery : IRequest<IEnumerable<AnimeData>>
    {
        
    }
}
