namespace NewShore.ETCore.Repositories.Configuration
{
    internal class JourneyFlightConfiguration : IEntityTypeConfiguration<CreateJourneyFlightDTO>
    {
        public void Configure(EntityTypeBuilder<CreateJourneyFlightDTO> builder)
        {
            builder.HasKey(jf => jf.JourneyFlightId);
            builder.Property(jf => jf.Origin).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(jf => jf.Destination).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(jf => jf.Price).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(jf => jf.Flights).IsRequired()
                .IsFixedLength();
        }
    }
}
