namespace NewShoreEntities.Interfaces.Ports
{
    public interface ICreateJourneyRouteInputPort
    {
        ValueTask Handle(ICreateJourneyRouteInputPort jouneyRouteDTO);
    }
}
