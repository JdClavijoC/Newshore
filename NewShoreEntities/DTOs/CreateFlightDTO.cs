using System.Collections.Generic;

namespace NewShoreEntities.DTOs
{
    public class CreateFlightDTO
    {
        public int FlightId { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public double? Price { get; set; }
        public string? Transport { get; set; }
    }
}
