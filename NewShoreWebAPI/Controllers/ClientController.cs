namespace NewShoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/client")]
    public class ClientController : ControllerBase
    {
        public readonly NewShoreBackEndService service;
        private string localDestination;
        private bool isCalulate = false;
        private double price = .0;


        public ClientController()
        {
            service = new NewShoreBackEndService();
        }

        [HttpGet]
        public async Task<List<NewShoreAirResponse>> getInfo()
        {
            List<NewShoreAirResponse> myFlightRaw = await service.GetNewShoreRuts();
            if (myFlightRaw == null) return null;
            return new List<NewShoreAirResponse>(myFlightRaw);

        }

        [HttpGet]
        [Route("calculateRoute")]
        public async Task<JourneyRoute> listClientPost(string origin, string destination)
        {
            localDestination = destination;
            List<NewShoreAirResponse> myFlightRaw = await service.GetNewShoreRuts();
            JourneyFlight Journeys = new JourneyFlight();
            JourneyRoute fJourney = new JourneyRoute();
            List<Flight> flights = new List<Flight>();

            for (int i = 0; i < myFlightRaw.Count; i++)
            {
                if (myFlightRaw[i].DepartureStation == origin)
                {
                    if (i == myFlightRaw.Count - 1) { break; }
                    destination = myFlightRaw[i + 1].ArrivalStation;
                    i = 0;
                    while (i < myFlightRaw.Count - 1)
                    {
                        if (myFlightRaw[i + 1].DepartureStation == destination)
                        {

                            flights.Add(
                                new Flight
                                {
                                    Origin = myFlightRaw[i + 1].DepartureStation,
                                    Destination = myFlightRaw[i + 1].ArrivalStation,
                                    Price = myFlightRaw[i + 1].Price,
                                    Transport = new Transport()
                                    {
                                        FlightCarrier = myFlightRaw[i + 1].FlightCarrier,
                                        FlightNumber = myFlightRaw[i + 1].FlightNumber
                                    },
                                });
                            price += myFlightRaw[i + 1].Price;
                            if (myFlightRaw[i + 1].ArrivalStation == localDestination)
                            {
                                isCalulate = true;
                                break;
                            }
                            destination = myFlightRaw[i + 1].ArrivalStation;
                        }
                        i++;
                    }
                    break;
                }
            }
            if (!isCalulate && flights.Count == 0)
            {
                Journeys = new JourneyFlight
                {
                    Origin = origin,
                    Destination = localDestination,
                    Price = 0,
                    Status = "FALLA AL CALCULAR LA RUTA",
                    Flights = flights,
                };
                fJourney = new JourneyRoute
                {
                    journey = Journeys,
                };
            }
            else
            {
                Journeys = new JourneyFlight
                {
                    Origin = origin,
                    Destination = localDestination,
                    Price = price,
                    Status = "RUTA CALCULADA CON EXITO",
                    Flights = flights,
                };
                fJourney = new JourneyRoute
                {
                    journey = Journeys,
                };
            }
            return fJourney;
        }
    }
}
