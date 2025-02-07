using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebAPI.Mediator.Anime;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : ControllerBase
    {
        private readonly ILogger<AnimeController> _logger;
        private readonly IMediator _mediator;
        private readonly HttpSettings _httpSettings;

        public AnimeController(ILogger<AnimeController> logger, IMediator mediator, IOptions<HttpSettings> httpSettings)
        {
            _logger = logger;
            _mediator = mediator;
            _httpSettings = httpSettings.Value;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAnimeQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert()
        {
            await _mediator.Send(new UpsertAnimeCommand { BaseUrl = _httpSettings.BaseUrl });
            return NoContent();
        }
    }
}
