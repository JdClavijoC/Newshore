namespace NewShore.ETCore.Repositories.Configuration
{
    internal class TransportConfiguration : IEntityTypeConfiguration<CreateTransportDTO>
    {
        public void Configure(EntityTypeBuilder<CreateTransportDTO> builder)
        {
            builder.HasKey(t => t.TransportId);
            builder.Property(t => t.FlightCarrier).IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();
            builder.Property(t => t.FlightNumber).IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();
        }
    }
}
