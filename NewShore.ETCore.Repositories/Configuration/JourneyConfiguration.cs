namespace NewShore.ETCore.Repositories.Configuration
{
    internal class JourneyConfiguration : IEntityTypeConfiguration<CreateJourneyRouteDTO>
    {
        public void Configure(EntityTypeBuilder<CreateJourneyRouteDTO> builder)
        {
            builder.HasKey(j => new {j.JourneyFlightId, j.JourneyId, j.FlightId});
        }
    }
}
