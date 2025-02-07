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
        public void RunUpsertAnimeListJob(string baseUrl, CancellationToken cancellationToken)
        {
            _httpService.UpsertAnimeList(baseUrl, cancellationToken);
            RecurringJob.AddOrUpdate(RECURRING_JOB, () => _httpService.UpsertAnimeList(baseUrl, cancellationToken), "*/10 * * * * *");
        }
    }
}
