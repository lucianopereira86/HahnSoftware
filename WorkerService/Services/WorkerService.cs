using ExternalResources.Services;
using Hangfire;

namespace WorkerService.Services
{
    /// <inheritdoc/>
    internal class WorkerService : IWorkerService
    {
        private const string RECURRING_JOB = "upsert_animelist";
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
        public async Task RunUpsertAnimeListJob(string baseUrl, CancellationToken cancellationToken)
        {
            await UpsertAnimeList(baseUrl, cancellationToken);
            RecurringJob.AddOrUpdate(RECURRING_JOB, () => UpsertAnimeList(baseUrl, cancellationToken), Cron.Minutely);
        }

        /// <inheritdoc/>
        public Task UpsertAnimeList(string baseUrl, CancellationToken cancellationToken)
        {
            return _httpService.UpsertAnimeList(baseUrl, cancellationToken);
        }
    }
}
