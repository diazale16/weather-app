using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APILocation
{  
    string apiProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    Utilities utilities = new Utilities();

    public Dictionary<string, double> Main()
    {
        string apiKey = utilities.GetAPIKey(jsonFilePath, apiProperty);
        string url = $"http://api.openweathermap.org/geo/1.0/zip?zip=5000,AR&appid={apiKey}";

        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = client.GetAsync(url).Result;
            string jsonString = response.Content.ReadAsStringAsync().Result;
            JObject json = JObject.Parse(jsonString);
            
            double lat = (double)json["lat"];
            double lon = (double)json["lon"];
            
            return new Dictionary<string, double>
            {
                { "latitud", lat },
                { "longitud", lon }
            };
        }
        catch (Exception ex)
        {
            string currentError = $"* [ ! ] Error: {ex.Message}. *";
            string delimiter = new string('*', currentError.Length);
            List<string> errorAdvice = new List<string>{delimiter,currentError,delimiter,""};
            Console.Clear();
            errorAdvice.ForEach(Console.WriteLine);
            throw;
        }
    }
}