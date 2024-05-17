using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class APIClimateData
{  
    string weatherLocationKeyProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    Utilities utilities = new Utilities();

    public Dictionary<string, double> Main()
    {
        string apiKey = utilities.getAPIKey(jsonFilePath, weatherLocationKeyProperty);
        string url = $"https://maps.googleapis.com/maps/api/geolocation/v1/geolocate?key={apiKey}";

        // TODO
        // Consumision de API 
        /* HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = client.PostAsync(url, null).Result;
            string jsonString = response.Content.ReadAsStringAsync().Result;
            JObject json = JObject.Parse(jsonString);
            double latitude = (double)json["location"]["lat"];
            double longitude = (double)json["location"]["lng"];
            Console.WriteLine($" Latitud: {latitude} \nLongitud: {longitude}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($" [!] Error: {ex.Message}");
            throw;
        } */

        Dictionary<string, double> coordenadas = new Dictionary<string, double>
        {
            { "latitud", 31.428199 },
            { "longitud", -64.192134 }
        };
        return coordenadas;
    }
}
