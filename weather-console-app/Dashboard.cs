
class Dashboard
{
    public required Coordenadas coordenadas { get; set; }
    public dynamic forecastObject { get; set; }
    // public Weather? forecastWeek { get; set; }
    // public Temperature? weatherDay { get; set; }

    
    internal void UpdateForescast()
    {
        forecastObject.Update(coordenadas);
    }
}