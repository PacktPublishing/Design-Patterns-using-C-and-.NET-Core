using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRPExample
{
    public static class ErrorHandler
    {
        public static bool HandleResponse(HttpStatusCode code)
        {
            if (code == HttpStatusCode.OK)
            {
                return true;
            }
            else if (code == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Countries API is momentarily unavailable");
                return false;
            }
            else if (code == HttpStatusCode.InternalServerError)
            {
                Console.WriteLine("Countries API encountered an error, please try again");
                return false;
            }
            else
            {
                Console.WriteLine("An error has occurred while fetching the countries");
                return false;
            }
        }
    }
}
