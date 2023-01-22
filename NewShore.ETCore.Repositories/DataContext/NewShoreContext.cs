namespace NewShore.ETCore.Repositories.DataContext
{
    // Add-Migration InitialCreate -p NewShore.ETCore.Repositories -s NewShore.ETCore.Repositories -c NewShoreContext
    // Update-Database -p NewShore.ETCore.Repositories -s NewShore.ETCore.Repositories -c NewShoreContext
    internal class NewShoreContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NewShoreDBV2");
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
