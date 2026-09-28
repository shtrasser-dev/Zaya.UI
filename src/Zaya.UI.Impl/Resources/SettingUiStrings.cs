using System.Globalization;
using System.Resources;

namespace Zaya.UI.Impl.Resources;

internal static class SettingUiStrings
{
    private static readonly ResourceManager Manager =
        new("Zaya.UI.Impl.Resources.Strings", typeof(SettingUiStrings).Assembly);

    public static string Get(string name, CultureInfo culture)
        => Manager.GetString(name, culture)
           ?? Manager.GetString(name, CultureInfo.GetCultureInfo("en"))
           ?? Manager.GetString(name, CultureInfo.InvariantCulture)
           ?? name;
}
