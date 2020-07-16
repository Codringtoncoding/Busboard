using System;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;


namespace Busboard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var apiCall = new ApiCall();
            var postCodeCall = new PostCodeCall();
            // var stopCode = GetStopCodeFromUser();
            // var LongLat = postCodeCall.GetPostCodeForLongLat(result);
            // var departures = apiCall.GetBusDeparturesForStop(stopCode);

            // PrintNextBuses(departures);
    
        }
        
        private static void PrintLongLat(PostCodeInfo result)
            {
                Console.WriteLine($"The Longitude is {result.longitude} and the {result.latitude}");
            }
        // private static void PrintNextBuses(BusDepartureResponse departures)
        // {
        //     Console.WriteLine($"\n\nNext buses at {departures.Name}");
        //     foreach (var departure in departures.departures.All.Take(5))
        //     {
        //         Console.WriteLine($"Line: {departure.Line}, To: {departure.direction}, Leaving at: {departure.ExpectedDepartureTime}");
        //     }
        

        // private static string GetPostCodeFromUser()
        // {
        //     Console.WriteLine("Please enter a postcode");
        //     string postcode = Console.ReadLine();

        //     // var postcode = postcode;



        // }

        // private static string GetStopCodeFromUser()
        // {
        //     Console.WriteLine("Please enter the bus stop code:");
        //     return Console.ReadLine();
        // }
    }

}
