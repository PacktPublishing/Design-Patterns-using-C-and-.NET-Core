using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedExample
{
    public static class CountriesFormatter
    {
        public static string FormatForConsole(Country country)
        {
            return $"{country.Name}, Capital: {country.Capital} - Region: {country.Region}";
        }
    }
}
