namespace NewShoreEntities.DTOs
{
    public class CreateTransportDTO
    {
        public int TransportId { get; set; }
        public string? FlightCarrier { get; set; }
        public string? FlightNumber { get; set; }
    }
}
