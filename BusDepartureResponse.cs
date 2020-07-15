namespace Busboard
{
    public class BusDepartureResponse
    {
       public string Name { get; set;}
       public Departures departures { get; set; }
    }

    public class Departures
    {
        public List<DepartureInfo> All { get; set;}
    }

    public class DepartureInfo
    {
        public string Line {get; set;}
        public string direction {get; set;} 

        public string  date {get; set;}

        public string ExpectedDepartureTime {get; set;}

        public string ExpectedArrivalTime {get; set;}

    }
}

}