using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APILocation
{  
    string mapsLocationKeyProperty = "maps_location_key";
    string jsonFilePath = "APIKeys.json";

    public string getAPIKey()
    {
        try
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject jsonData = JObject.Parse(jsonContent);
            try
            {
                string locationAPIKey = jsonData[$"{mapsLocationKeyProperty}"].ToString();
                // Console.WriteLine($"{locationAPIKey}");
                return locationAPIKey;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($" [!] No existe una clave definidia para la propiedad {mapsLocationKeyProperty}");          
                return "null";      
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine(" [!] El archivo JSON no fue encontrado.");
            return "null";
        }
        catch (JsonException)
        {
            Console.WriteLine(" [!] Error al deserializar el JSON.");
            return "null";
        }

    }

    public Dictionary<string, double> Main()
    {
        string apiKey = getAPIKey();
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