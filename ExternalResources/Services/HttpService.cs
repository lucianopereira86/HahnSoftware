using Domain.Models.Anime.Response;
using System.Text.Json;

namespace ExternalResources.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions  _jsonSerializerOptions =  new() {  PropertyNameCaseInsensitive = true };
        public HttpService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<AnimeList> GetAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            using HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}/anime", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<AnimeList>(jsonResponse, _jsonSerializerOptions) ?? new();
            }
            return new();
        }
    }
}
