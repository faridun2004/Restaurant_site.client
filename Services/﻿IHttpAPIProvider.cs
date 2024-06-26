﻿using Microsoft.AspNetCore.Components;

namespace Restaurant_site.client.Services
{
    public interface IHttpAPIProvider
    {
        Task<(bool isSuccessStatusCode, T result, string message)> GetAsync<T>(string endponit) where T : class;
        Task<(bool isSuccessStatusCode, T result, string message)> PostAsync<T>(string endponit, object body = null) where T : class;
        Task<(bool isSuccessStatusCode, T result, string message)> PutAsync<T>(string endponit, object body = null) where T : class;
        Task<(bool isSuccessStatusCode, T result, string message)> DeleteAsync<T>(string endponit) where T : class;

        HttpClient GetHttpClient();
    }
}
