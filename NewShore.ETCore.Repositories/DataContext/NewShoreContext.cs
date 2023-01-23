namespace NewShore.ETCore.Repositories.DataContext
{
    // Add-Migration InitialCreate -p NewShore.ETCore.Repositories -s NewShore.ETCore.Repositories -c NewShoreContext
    // Update-Database -p NewShore.ETCore.Repositories -s NewShore.ETCore.Repositories -c NewShoreContext
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
