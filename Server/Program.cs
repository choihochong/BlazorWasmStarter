
using BlazorStarterkitWasm.Shared;
using BlazorStarterkitWasm.Shared.Themes.KeenThemes;
using BlazorStarterkitWasm.Shared.Themes.KeenThemes.libs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddHttpClient();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IKTTheme, KTTheme>();
builder.Services.AddSingleton<IBootstrapBase, BootstrapBase>();

IConfiguration configuration = new ConfigurationBuilder()
                           .AddJsonFile("themesettings.json")
                            .Build();

var app = builder.Build();

KTThemeSettings.init(configuration);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();


//using Microsoft.AspNetCore.ResponseCompression;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseWebAssemblyDebugging();
//}
//else
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseBlazorFrameworkFiles();
//app.UseStaticFiles();

//app.UseRouting();


//app.MapRazorPages();
//app.MapControllers();
//app.MapFallbackToFile("index.html");

//app.Run();


