class Dashboard
{
    public Dictionary<string, double> coordenadas { get; set; }
    public Forecast? forecastWeek { get; set; }
    public Temperature? weatherDay { get; set; }

    public void Main()
    {
        Console.WriteLine($"holaa");
    }
}