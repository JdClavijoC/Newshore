namespace NewShoreEntities.Entities
{
    public class JourneyFlight
    {
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public double? Price { get; set; }
        public string? Status { get; set; }
        public List<Flight>? Flights { get; set; }
    }
}
