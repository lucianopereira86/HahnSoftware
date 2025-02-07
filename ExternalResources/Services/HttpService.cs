using Domain.Models.Anime.Dto;
using System.Text.Json;

namespace ExternalResources.Services
{
    /// <inheritdoc/>
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions  _jsonSerializerOptions =  new() {  PropertyNameCaseInsensitive = true };

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpService"/> class.
        /// </summary>
        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        /// <inheritdoc/>
        public async Task<AnimeListDto> GetAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            using HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}/anime", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<AnimeListDto>(jsonResponse, _jsonSerializerOptions) ?? new();
            }
            return new();
        }

        /// <inheritdoc/>
        public async Task UpsertAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            Console.WriteLine("UpsertAnimeList started...");
            await _httpClient.PostAsync(baseUrl, null, cancellationToken);
            Console.WriteLine("UpsertAnimeList completed.");
        }
    }
}
