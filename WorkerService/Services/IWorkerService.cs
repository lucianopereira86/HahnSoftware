namespace WorkerService.Services
{
    /// <summary>
    /// The worker service.
    /// </summary>
    internal interface IWorkerService
    {
        /// <summary>
        /// Sends request to the endpoint responsible for deleting and inserting animes.
        /// </summary>
        /// <param name="baseUrl">The base Url for the endpoint.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        void UpsertAnimeList(string baseUrl, CancellationToken cancellationToken);
    }
}