using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Forecast
{
    public WeatherResponseWeekly Update(Coordenadas coords)
    {   
        string lat = coords.latitud.ToString();
        string lon = coords.longitud.ToString();
        string cant = 7.ToString();
        string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&units=metric&cnt={cant}"; // &cnt={cant}

        APIClimateData apiClima =  new APIClimateData();
        string jsonRespuesta = apiClima.Main(url);
        WeatherResponseWeekly weatherResponse = JsonConvert.DeserializeObject<WeatherResponseWeekly>(jsonRespuesta);

        return weatherResponse;
    }
}