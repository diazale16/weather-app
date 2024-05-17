
class Dashboard
{
    public Dictionary<string, double> coordenadas { get; set; }
    public required DecisionManager decisionObject { get; set; }
    
    // public Forecast? forecastWeek { get; set; }
    // public Temperature? weatherDay { get; set; }

    internal void updateForescast()
    {
        throw new NotImplementedException();
    }
}