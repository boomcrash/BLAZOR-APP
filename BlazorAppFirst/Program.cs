using BlazorAppFirst;
using BlazorAppFirst.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = builder.Configuration.GetValue<string>("apiUrl"); 
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });


//agregar los servicios generados con su interfaz
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<ProductService>();

await builder.Build().RunAsync();
