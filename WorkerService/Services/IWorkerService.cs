namespace WorkerService.Services
{
    internal interface IWorkerService
    {
        void UpsertAnimeList(string baseUrl, CancellationToken cancellationToken);
    }
}