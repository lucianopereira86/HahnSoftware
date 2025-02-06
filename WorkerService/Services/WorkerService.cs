using ExternalResources.Services;
using Hangfire;

namespace WorkerService.Services
{
    internal class WorkerService : IWorkerService
    {
        private readonly IHttpService _httpService;

        public WorkerService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public void UpsertAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            RecurringJob.AddOrUpdate("upsert_animelist", () => _httpService.UpsertAnimeList(baseUrl, cancellationToken), Cron.Minutely);
        }
    }
}
