using Newtonsoft.Json.Linq;

class Temperature
{
    public void Update(Coordenadas coords)
    {   
        string lat = coords.latitud.ToString();
        string lon = coords.longitud.ToString();
        string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric";

        APIClimateData apiClima =  new APIClimateData();
        JObject jsonRespuesta = apiClima.Main(url);
        Console.WriteLine($"{jsonRespuesta}");
        
        
    }
}