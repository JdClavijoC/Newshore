namespace NewShore.ETCore.Repositories.DataContext
{
    internal class NewShoreContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-QRG1OFAQ;Database=NewshoreDB2;Trusted_Connection=True;Encrypt=False");
        }

        public DbSet<CreateJourneyRouteDTO> FJourneys { get;set; }
        public DbSet<CreateJourneyFlightDTO> Journeys { get;set; }
        public DbSet<CreateFlightDTO> Flights { get;set; }
        public DbSet<CreateTransportDTO> Transports { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
