using Domain.Models;
using Domain.Models.Anime.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebAPI.Mediator.Anime;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Anime controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AnimeController : ControllerBase
    {
        private readonly ILogger<AnimeController> _logger;
        private readonly IMediator _mediator;
        private readonly HttpSettings _httpSettings;

        /// <summary>
        /// Creates a new instance of <see cref="AnimeController" />.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="mediator">The mediator.</param>
        /// <param name="httpSettings">The Http settings.</param>
        public AnimeController(ILogger<AnimeController> logger, IMediator mediator, IOptions<HttpSettings> httpSettings)
        {
            _logger = logger;
            _mediator = mediator;
            _httpSettings = httpSettings.Value;
        }

        /// <summary>
        /// List all animes.
        /// </summary>
        /// <returns>List of animes.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<AnimeData>> GetAll()
        {
            return await _mediator.Send(new GetAnimeQuery());
        }

        /// <summary>
        /// Deletes and inserts all animes.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task Upsert()
        {
            await _mediator.Send(new UpsertAnimeCommand { BaseUrl = _httpSettings.BaseUrl });
        }
    }
}
