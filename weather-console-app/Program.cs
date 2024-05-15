using System;
using static WeatherApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("WEATHER FORECAST APPLICATION");
        WeatherApp app = new WeatherApp();
        app.Run();
        Console.WriteLine($"testeo a ver si llega");    
    }
    
    /* app.Run() */
}