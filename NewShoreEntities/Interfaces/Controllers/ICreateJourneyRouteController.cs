namespace NewShoreEntities.Interfaces.Controllers
{
    public interface ICreateJourneyRouteController
    {
        ValueTask<int> CreateJourneyRoute(CreateJourneyRouteDTO journeyRoute);
    }
}
