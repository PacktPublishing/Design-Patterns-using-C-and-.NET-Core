using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedExample
{
    public class CountriesConsoleFormatter
    {
        public static string Format(Country country)
        {
            return $"{country.Name} / {country.Capital} / {country.Region}";
        }
    }
}
