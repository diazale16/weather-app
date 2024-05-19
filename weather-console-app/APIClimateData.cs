using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APIClimateData
{  
    string apiProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    Utilities utilities = new Utilities();

    public JObject Main(string url)
    {
        string apiKey = utilities.GetAPIKey(jsonFilePath, apiProperty);
        string urlFinal = url + $"&appid={apiKey}";

        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = client.GetAsync(urlFinal).Result;
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