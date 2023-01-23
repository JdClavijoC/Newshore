namespace NewShoreEntities.Interfaces.Ports
{
    public interface ICreateJourneyRouteOutputPort
    {
        ValueTask Handle(int jouneyRouteId);
    }
}
