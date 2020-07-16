using System;
using System.Collections.Generic;


namespace Busboard
{
    public class PostCodeResponse
    {
        public Results result {get; set;}
    
    }

    public class Results
    {
        public List<PostCodeInfo> Result {get; set;}
    }

    public class PostCodeInfo
    {

        public float longitude {get; set;}

        public float latitude {get; set;}


    }

}