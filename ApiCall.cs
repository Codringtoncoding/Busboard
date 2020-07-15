using System;
using RestSharp;
using RestSharp.Authenticators;
using System.Collection.Generic;

namespace Busboard
{
    public class ApiCall
    {
        public string Name { get; set;}
        public List<Departures> Departures {get; set;}
             


        public static void GetApiRequest(String ApiCall)
        {
            var client = new RestClient("https://transportapi.com");
            var request = new RestRequest("Busboard/bus_timetable.json",DataFormat.Json)
            .AddQueryParameter("app_id=57f92325&app_key=2d2f58df70eea1ad52dfd4613d9b50f4&group=route&nextbuses=yes", string);
            var response = client.Get<Departures>(request);
            
        }
    }
}
