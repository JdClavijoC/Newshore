namespace NewShoreEntities.Interfaces.Ports
{
    public interface ICreateJourneyRouteInputPort
    {
        // Por Implementar
        ValueTask Handle(ICreateJourneyRouteInputPort jouneyRouteDTO);
    }
}
