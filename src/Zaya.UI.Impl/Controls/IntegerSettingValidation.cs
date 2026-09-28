using System.Globalization;
using Zaya.Primitives;
using Zaya.UI.Impl.Resources;

namespace Zaya.UI.Impl.Controls;

/// <summary>Validates integer setting text against descriptor min/max.</summary>
public static class IntegerSettingValidation
{
    public static bool TryParse(
        string? text,
        IntegerSettingDescriptor desc,
        CultureInfo culture,
        out int value,
        out string? errorMessage)
    {
        value = 0;
        errorMessage = null;

        if (!int.TryParse(text, NumberStyles.Integer, culture, out value)
            && !int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
        {
            errorMessage = FormatRangeError(desc, culture);
            return false;
        }

        if (desc.MinValue is int min && value < min)
        {
            errorMessage = FormatRangeError(desc, culture);
            return false;
        }

        if (desc.MaxValue is int max && value > max)
        {
            errorMessage = FormatRangeError(desc, culture);
            return false;
        }

        return true;
    }

    public static string FormatRangeError(IntegerSettingDescriptor desc, CultureInfo culture)
    {
        var min = desc.MinValue ?? int.MinValue;
        var max = desc.MaxValue;

        if (max is null || max == int.MaxValue)
        {
            return string.Format(
                culture,
                SettingUiStrings.Get("Validation_IntegerMinOnly", culture),
                min);
        }

        return string.Format(
            culture,
            SettingUiStrings.Get("Validation_IntegerRange", culture),
            min,
            max.Value);
    }
}
