using Microsoft.EntityFrameworkCore;
using NewShoreEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreRepository.DataContext
{
    public class NewShoreContext: DbContext
    {
        public NewShoreContext(DbContextOptions<NewShoreContext> options) { }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<FJourney> Fourneys { get; set; }
        public DbSet<Transport> Transports { get; set; }
    }
}
