﻿using BlazorAppFirst.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorAppFirst.Services
{
    public class ProductService : IProductService
    {

        public readonly HttpClient client;
        private readonly JsonSerializerOptions options;

        public ProductService(HttpClient httpClient)
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


        public async Task Add(Product product)
        {
            var response = await client.PostAsync("Products",JsonContent.Create(product));
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

        }

        public async Task Delete(int productId)
        {
            var response = await client.DeleteAsync($"Products/{productId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

        }
    }
}

public interface IProductService
{
    Task<List<Product>> Get();
    Task Add(Product product);
    Task Delete(int productId);
}

