using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiClient
{
    public abstract class ApiClientBase<TDto, TEntity> where TDto : class where TEntity : class
    {
        protected static readonly HttpClient client = Client();

        private static HttpClient Client ()
        {
            HttpClient client =  new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5183/");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        protected abstract string ApiRoute { get; }

        public async Task<TEntity?> GetAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<TEntity>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

        public async Task<List<TDto>?> GetAllAsync()
        {
            HttpResponseMessage response = await client.GetAsync(ApiRoute);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<TDto>>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

        public async Task AddAsync(TEntity entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(ApiRoute, entity);
            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

        public async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{ApiRoute}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(ApiRoute, entity);
            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
    
    }
}
