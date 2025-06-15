// ThemeService.cs
using System;

public class ThemeService
{
    // The current theme name (e.g. "material" or "materialDark")
    public string Theme { get; private set; } = "material";
    public event Action? ThemeChanged;

    // Switches to a specific theme and notifies
    public void SetTheme(string theme)
    {
        Theme = theme;
        ThemeChanged?.Invoke();
    }

    // Toggles between the light and dark variant
    public void Toggle()
    {
        var next = Theme.EndsWith("Dark", StringComparison.OrdinalIgnoreCase)
            ? Theme.Replace("Dark", "", StringComparison.OrdinalIgnoreCase)
            : Theme + "Dark";
        SetTheme(next);
    }
}
