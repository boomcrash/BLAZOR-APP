using BlazorAppFirst.Models;
using System.Text.Json;

namespace BlazorAppFirst.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly HttpClient client;
        private readonly JsonSerializerOptions options;

        public CategoryService(HttpClient httpClient)
        {
            this.client = httpClient;
            options = new JsonSerializerOptions { PropertyNameCaseInsensitive=true};
        }

        public async Task<List<Category>?> Get()
        {
            var response = await client.GetAsync("categories");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return  JsonSerializer.Deserialize<List<Category>>(content, options);

        }

    }

}

public interface ICategoryService
{
    Task<List<Category>> Get();
}
