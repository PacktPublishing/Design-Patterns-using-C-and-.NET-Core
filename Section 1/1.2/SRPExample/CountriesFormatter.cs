using System;
using System.Collections.Generic;
using System.Text;

namespace SRPExample
{
    public static class CountriesFormatter
    {
        public static string FormatForConsole(Country country)
        {
            return $"{country.Name}, Capital: {country.Capital} - Region: {country.Region}";
        }
    }
}
