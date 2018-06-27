using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedExample
{
    public class CountryFormatter
    {
        public virtual string Format(Country country)
        {
            return $"{country.Name} - {country.Capital} - {country.Region}";
        }
    }
}
