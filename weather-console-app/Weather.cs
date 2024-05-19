using Newtonsoft.Json.Linq;

class Forecast
{
    public void Update(Coordenadas coords)
    {   
        string lat = coords.latitud.ToString();
        string lon = coords.longitud.ToString();
        string cant = 7.ToString();
        string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&cnt={cant}&units=metric";

        APIClimateData apiClima =  new APIClimateData();
        JObject jsonRespuesta = apiClima.Main(url);
        Console.WriteLine($"{jsonRespuesta}");
        
    }
}