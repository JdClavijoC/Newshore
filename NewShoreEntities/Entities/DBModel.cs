using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreEntities.Entities
{
    public class ModelFlight
    {
        public string? origin { get; set; }
        public string? destination { get; set; }
        public double? price { get; set; }
        public Transport? transport { get; set; }
    }

    public class ModelJourney
    {
        public string? origin { get; set; }
        public string? destination { get; set; }
        public int? price { get; set; }
        public List<Flight>? flights { get; set; }
    }

    //public class Root
    //{
    //    public Journey journey { get; set; }
    //}

    public class ModelTransport
    {
        public string? flightCarrier { get; set; }
        public string? flightNumber { get; set; }
    }
}
