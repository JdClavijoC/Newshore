using NewShoreEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
