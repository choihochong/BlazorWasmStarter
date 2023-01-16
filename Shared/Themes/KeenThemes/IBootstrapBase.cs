using BlazorStarterkitWasm.Shared.Themes.KeenThemes.libs;

namespace BlazorStarterkitWasm.Shared.Themes.KeenThemes;

public interface IBootstrapBase
{
    void initThemeMode();
    
    void initThemeDirection();
    
    void initRtl();

    void initLayout();

    void init(IKTTheme theme);
}