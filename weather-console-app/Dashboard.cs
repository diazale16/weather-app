
class Dashboard
{
    public Dictionary<string, double> coordenadas { get; set; }
    public dynamic forecastObject { get; set; }
    
    // public Forecast? forecastWeek { get; set; }
    // public Temperature? weatherDay { get; set; }

    
    internal void updateForescast()
    {
        if (forecastObject){ forecastObject.update(); }
    }
}