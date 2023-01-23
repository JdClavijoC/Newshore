namespace NewShore.ETCore.Repositories.Configuration
{
    internal class FlightConfiguration : IEntityTypeConfiguration<CreateFlightDTO>
    {
        public void Configure(EntityTypeBuilder<CreateFlightDTO> builder)
        {
            builder.HasKey(o => o.FlightId);
            builder.Property(o => o.Origin).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(o => o.Destination).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(o => o.Price).IsRequired()
                .HasMaxLength(3)
                .IsFixedLength();
            builder.Property(o => o.Transport).IsRequired()
                .IsFixedLength();

        }
    }
}
