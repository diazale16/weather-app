using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Temperature
{
    
    public WeatherResponseDaily Update(Coordenadas coords)
    {   
        string lat = coords.latitud.ToString();
        string lon = coords.longitud.ToString();
        string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric";

        APIClimateData apiClima =  new APIClimateData();
        string jsonRespuesta = apiClima.Main(url);
        WeatherResponseDaily weatherResponse = JsonConvert.DeserializeObject<WeatherResponseDaily>(jsonRespuesta);
        
        return weatherResponse;
    }
}
