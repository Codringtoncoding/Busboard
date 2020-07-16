using System;
using RestSharp;

namespace Busboard
{
    public class PostCodeCall
    {
        private RestClient client;

        public PostCodeCall()
        {
            client = new RestClient("https://api.postcodes.io/");
        }

        public PostCodeResponse GetPostCodeForLongLat(string postcode)
        {
            var postcoderequest = new RestRequest("postcodes/W105LY/");
            // .AddUrlSegment("postcode", postcode);

            
            var response = client.Get<PostCodeResponse>(postcoderequest);
            return response.Data;
        }
    }
}


//  https://api.postcodes.io/postcodes/:postcode
