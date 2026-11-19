using System.Globalization;

namespace BlazingPizza.Services;

/// <summary>
/// Central currency formatter. nl-NL formats decimal prices as euros using
/// Dutch number conventions, for example € 12,50.
/// Call this helper anywhere a price is displayed.
/// </summary>
public static class CurrencyFormatter
{
    private static readonly CultureInfo DutchCulture = CultureInfo.GetCultureInfo("nl-NL");

    public static string Euro(decimal amount) => amount.ToString("C", DutchCulture);
}
