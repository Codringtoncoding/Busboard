using System;
using RestSharp;

namespace Busboard
{
    public class ApiCall
    {
        private RestClient client;
        public ApiCall()
        {
            client = new RestClient("https://transportapi.com/");
  ;
        }
        public BusDepartureResponse GetBusDeparturesForStop(string stopcode)
        {
       
            var request = new RestRequest("/v3/uk/bus/stop/{stopcode}/live.json?")
            .AddUrlSegment("stopcode", stopcode)
            .AddQueryParameter("app_id", "57f92325")
            .AddQueryParameter("app_key", "2d2f58df70eea1ad52dfd4613d9b50f4")
            .AddQueryParameter("group", "no")
            .AddQueryParameter("nextbuses", "yes");
            
            var response = client.Get<BusDepartureResponse>(request);
            return response.Data;
        } 

    }
}
