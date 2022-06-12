using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToxiCode.BuyIt.Logistics.Ui;
using ToxiCode.BuyIt.Logistics.Ui.Services;
using ToxiCode.BuyIt.Logistics.Ui.Services.Abstractions;

// Console.WriteLine('\n');
#region Services

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services
    .AddScoped<IItemService, ItemService>()
    .AddScoped<IOrderService, OrderService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.api.logistics.buyit.txcd.xyz") });//http://localhost:5000

#endregion

#region App

await builder
    .Build()
    .RunAsync();

#endregion