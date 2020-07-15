using System;
using RestSharp;
using RestSharp.Authenticators;


namespace Busboard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var apiCall = new ApiCall();

            var departures = apiCall.GetBusDeparturesForStop("490008660N");
            Console.Write(departures);
    
        }
    }
}
