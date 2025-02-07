using ExternalResources.Services;
using Hangfire;

namespace WorkerService.Services
{
    /// <inheritdoc/>
    internal class WorkerService : IWorkerService
    {
        private readonly IHttpService _httpService;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerService"/> class.
        /// </summary>
        /// <param name="httpService"></param>
        public WorkerService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        /// <inheritdoc/>
        public void UpsertAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            RecurringJob.AddOrUpdate("upsert_animelist", () => _httpService.UpsertAnimeList(baseUrl, cancellationToken), Cron.Minutely);
        }
    }
}
