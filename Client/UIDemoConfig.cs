
#region Using directives
using Blazorise;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Blazorise.FluentValidation;
using Blazorise.LoadingIndicator;
#endregion

namespace BlazorStarterkitWasm.Client;

public static class UIDemoConfig
{
    public static IServiceCollection SetupDemoServices(this IServiceCollection services)
    {
        services
            .AddBlazorise(options =>
            {
                options.Immediate = true;
            })
            .AddLoadingIndicator()
            .AddBlazoriseFluentValidation();

        services.AddValidatorsFromAssembly(typeof(App).Assembly);

        services.AddMemoryCache();

        // register demo services to fetch test data
        services.AddScoped<BlazorStarterkitWasm.Shared.Data.UIDemo.EmployeeData>();
        services.AddScoped<BlazorStarterkitWasm.Shared.Data.UIDemo.CountryData>();

        return services;
    }


    /// <summary>
    /// Adds an implementation of the FluentValidationHandler implementation of the IValidationHandler interface
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddBlazoriseFluentValidation(this IServiceCollection services)
    {
        services.AddScoped<FluentValidationHandler>();

        return services;
    }

    /// <summary>
    /// Register LoadingIndicator service.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <returns></returns>
    public static IServiceCollection AddLoadingIndicator(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddScoped<ILoadingIndicatorService, LoadingIndicatorService>();
    }
}
