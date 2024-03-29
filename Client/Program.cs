using BlazorStarterkitWasm.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using DevExpress.Blazor;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


//Blazorise
builder.Services
  .AddBlazorise(options =>
  {
      options.Immediate = true;
  })
  .SetupDemoServices()
  .AddBootstrap5Providers()
  .AddFontAwesomeIcons()
  .AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
  


//Blazorise

await builder.Build().RunAsync();
