using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APIClimateData
{  
    string apiProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    Utilities utilities = new Utilities();

    // string json1 = "{\"coord\":{\"lon\":-64.175,\"lat\":-31.425},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"base\":\"stations\",\"main\":{\"temp\":7.62,\"feels_like\":6.02,\"temp_min\":7.62,\"temp_max\":7.62,\"pressure\":976,\"humidity\":68},\"visibility\":10000,\"wind\":{\"speed\":2.48,\"deg\":19,\"gust\":4.14},\"clouds\":{\"all\":6},\"dt\":1716088488,\"sys\":{\"type\":2,\"id\":2036678,\"country\":\"AR\",\"sunrise\":1716116413,\"sunset\":1716153988},\"timezone\":-10800,\"id\":3860259,\"name\":\"Córdoba\",\"cod\":200}";
    // string json2 = "{\"cod\":\"200\",\"message\":0,\"cnt\":7,\"list\":[{\"dt\":1716098400,\"main\":{\"temp\":7.38,\"feels_like\":5.92,\"temp_min\":6.91,\"temp_max\":7.38,\"pressure\":993,\"sea_level\":993,\"grnd_level\":969,\"humidity\":69,\"temp_kf\":0.47},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":2},\"wind\":{\"speed\":2.25,\"deg\":15,\"gust\":3.8},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2024-05-19 06:00:00\"},{\"dt\":1716109200,\"main\":{\"temp\":6.53,\"feels_like\":5.18,\"temp_min\":5.99,\"temp_max\":6.53,\"pressure\":1009,\"sea_level\":1009,\"grnd_level\":968,\"humidity\":72,\"temp_kf\":0.54},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.97,\"deg\":18,\"gust\":3.37},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2024-05-19 09:00:00\"},{\"dt\":1716120000,\"main\":{\"temp\":7.04,\"feels_like\":6.12,\"temp_min\":7.04,\"temp_max\":7.04,\"pressure\":1026,\"sea_level\":1026,\"grnd_level\":969,\"humidity\":70,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear...";

    public string Main(string url)
    {
        string apiKey = utilities.GetAPIKey(jsonFilePath, apiProperty);
        string urlFinal = url + $"&appid={apiKey}";

        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = client.GetAsync(urlFinal).Result;
            string jsonString = response.Content.ReadAsStringAsync().Result;
            return jsonString;
        }
        catch (Exception ex)
        {
            string currentError = $"* [ ! ] Error: {ex.Message}. *";
            utilities.PrintError(currentError);
            throw;
        }
    }
}
