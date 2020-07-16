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
            var postcoderequest = new RestClient("https://api.postcodes.io/postcodes/W105LY/");
            
            var response = client.Get<PostCodeResponse>(postcoderequest);
            return response.Data;
        }
    }
}


//  https://api.postcodes.io/postcodes/:postcode
