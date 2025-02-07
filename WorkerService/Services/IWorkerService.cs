namespace WorkerService.Services
{
    /// <summary>
    /// The worker service.
    /// </summary>
    internal interface IWorkerService
    {
        /// <summary>
        /// Run job that sends request to the endpoint responsible for deleting and inserting animes.
        /// </summary>
        /// <param name="baseUrl">The base Url for the endpoint.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task RunUpsertAnimeListJob(string baseUrl, CancellationToken cancellationToken);

        /// <summary>
        /// Sends request to the endpoint responsible for deleting and inserting animes.
        /// </summary>
        /// <param name="baseUrl">The base Url for the endpoint.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task UpsertAnimeList(string baseUrl, CancellationToken cancellationToken);
    }
}