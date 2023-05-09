using BlazorAppFirst.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorAppFirst.Services
{
    public class rickAndMortyServices
    {

        public readonly HttpClient client;
        private readonly JsonSerializerOptions options;

        public rickAndMortyServices(HttpClient httpClient)
        {
            this.client = httpClient;
            options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<Product>?> Get()
        {
            var response = await client.GetAsync("Products");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonSerializer.Deserialize<List<Product>>(content, options);
        }
    }
    public interface IRickService
    {
        Task<List<rickAndMorty>> Get();
    }
}
