
class Dashboard
{
    public required Coordenadas coordenadas { get; set; }
    public dynamic forecastObject { get; set; }
    
    internal dynamic UpdateForescast()
    {
        dynamic weatherResponseObject = forecastObject.Update(coordenadas);
        return weatherResponseObject;
    }
}