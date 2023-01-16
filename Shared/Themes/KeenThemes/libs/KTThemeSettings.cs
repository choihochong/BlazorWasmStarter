
using Microsoft.Extensions.Configuration;

namespace BlazorStarterkitWasm.Shared.Themes.KeenThemes.libs;

public class KTThemeSettings
{
    public static KTThemeBase config;

    public static void init(IConfiguration configuration)
    {
        config = configuration.GetSection("Theme").Get<KTThemeBase>();
    }
}
