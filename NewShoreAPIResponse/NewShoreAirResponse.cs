using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace NewShoreAPIResponse
{
    public class NewShoreAirResponse
    {
        public string DepartureStation { get; set; }

        public string ArrivalStation { get; set; }

        public string FlightCarrier { get; set; }

        public string FlightNumber { get; set; }

        public double Price { get; set; }
    }
}
