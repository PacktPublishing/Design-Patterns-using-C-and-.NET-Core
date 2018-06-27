using System;
using System.Threading.Tasks;

namespace SRPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            testCountries().Wait();
            Console.ReadKey();
        }

        private async static Task testCountries()
        {
            CountriesManager manager = new CountriesManager();
            var countries = await manager.GetEuropeanCountries();
            foreach(var country in countries)
            {
                Console.WriteLine(CountriesFormatter.FormatForConsole(country));
            }
        }
    }
}
