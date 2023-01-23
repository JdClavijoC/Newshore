﻿using NewShoreEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreEntities.Interfaces.Controllers
{
    public interface ICreateJourneyRouteController
    {
        // Por Implementar
        ValueTask<int> CreateJourneyRoute(CreateJourneyRouteDTO journeyRoute);
    }
}