using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Temperature
{
    
    public void Update(Coordenadas coords)
    {   
        string lat = coords.latitud.ToString();
        string lon = coords.longitud.ToString();
        string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric";

        APIClimateData apiClima =  new APIClimateData();
        // JObject jsonRespuesta = apiClima.Main(url);
        string jsonRespuesta = apiClima.Main(url);
        Console.WriteLine($"{jsonRespuesta}");
        WeatherResponseDaily weatherResponse = JsonConvert.DeserializeObject<WeatherResponseDaily>(jsonRespuesta);
        
        Console.WriteLine($"{weatherResponse.Name}");
        Console.WriteLine($"{weatherResponse.Main.Temp}");
        Console.WriteLine($"{weatherResponse.Main.TempMax}");
        Console.WriteLine($"{weatherResponse.Main.TempMin}");
        Console.WriteLine($"{weatherResponse.Weather[0].Description}");
        

        
    }
}
