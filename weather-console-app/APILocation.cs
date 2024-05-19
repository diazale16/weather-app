using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APILocation
{  
    string apiProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    string zipCode = 5000.ToString();
    string countryIsoId = "AR";
    Utilities utilities = new Utilities();

    public JObject Main()
    {
        string apiKey = utilities.GetAPIKey(jsonFilePath, apiProperty);
        string url = $"http://api.openweathermap.org/geo/1.0/zip?zip={zipCode},{countryIsoId}&appid={apiKey}"; //5000

        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = client.GetAsync(url).Result;
            string jsonString = response.Content.ReadAsStringAsync().Result;
            JObject json = JObject.Parse(jsonString);
            return json;
        }
        catch (Exception ex)
        {
            string currentError = $"* [ ! ] Error: {ex.Message}. *";
            utilities.PrintError(currentError);
            throw;
        }
    }
}