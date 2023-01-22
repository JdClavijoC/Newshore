namespace NewShoreEntities.DTOs
{
    public class CreateJourneyFlightDTO
    {
        public int JourneyFlightId { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public double Price { get; set; }
        public string? Flights { get; set; }
    }
}
