namespace NewShoreEntities.Interfaces.Ports
{
    public interface ICreateJourneyRouteOutputPort
    {
        // Por Implementar
        ValueTask Handle(int jouneyRouteId);
    }
}
