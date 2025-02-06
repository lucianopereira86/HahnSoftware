﻿using Domain.Models.Anime.Response;

namespace ExternalResources.Services
{
    public interface IHttpService
    {
        Task<AnimeList> GetAnimeList(string baseUrl, CancellationToken cancellationToken);
    }
}