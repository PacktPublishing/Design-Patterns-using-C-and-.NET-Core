using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SRPExample
{
    class CountriesManager
    {
        private HttpClient _http;
        private Country[] _countries;

        public CountriesManager()
        {
            _http = new HttpClient();
        }

        public async Task<Country[]> GetCountries()
        {
            if(_countries != null)
            {
                return _countries;
            }
            else
            {
                await GetAll();
                return _countries;
            }
        }

        public async Task<Country[]> GetEuropeanCountries()
        {
            if(_countries != null)
            {
                List<Country> europeanCountries = new List<Country>();
                foreach(var country in _countries)
                {
                    if(country.Region == "Europe")
                    {
                        europeanCountries.Add(country);
                    }
                }
                return europeanCountries.ToArray();
            }
            else
            {
                await GetAll();
                return await GetEuropeanCountries();
            }
        }

        public async Task<Country[]> GetAsianCountries()
        {
            if(_countries != null)
            {
                List<Country> asianCountries = new List<Country>();
                foreach(var country in _countries)
                {
                    asianCountries.Add(country);
                }
                return asianCountries.ToArray();
            }
            else
            {
                await GetAll();
                return await GetAsianCountries();
            }
        }

        public async Task GetAll()
        {
            HttpResponseMessage response = await _http.GetAsync("https://restcountries.eu/rest/v2/all");
            if(ErrorHandler.HandleResponse(response.StatusCode))
            {
                var content = await response.Content.ReadAsStringAsync();
                _countries = JsonConvert.DeserializeObject<Country[]>(content);
            }
        }

      
    }
}
