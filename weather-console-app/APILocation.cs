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
                return locationAPIKey;
            }
            catch (NullReferenceException)
            {
                string currentError = $" [ ! ] No existe una clave definidia para la propiedad [{mapsLocationKeyProperty}].";
                string delimiter = new string('*', currentError.Length);
                List<string> errorAdvice = new List<string>{delimiter,currentError,delimiter,""};
                Console.Clear();
                errorAdvice.ForEach(Console.WriteLine);          
                return "null";      
            }
        }
        catch (FileNotFoundException)
        {
            string currentError = $" [ ! ] No se encontro el archivo [{jsonFilePath}].";
            string delimiter = new string('*', currentError.Length);
            List<string> errorAdvice = new List<string>{delimiter,currentError,delimiter,""};
            Console.Clear();
            errorAdvice.ForEach(Console.WriteLine);          
            return "null";
        }
        catch (JsonException)
        {
            string currentError = $" [ ! ] Excepcion de JSON.";
            string delimiter = new string('*', currentError.Length);
            List<string> errorAdvice = new List<string>{delimiter,currentError,delimiter,""};
            Console.Clear();
            errorAdvice.ForEach(Console.WriteLine);  
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