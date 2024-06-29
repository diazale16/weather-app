using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class APILocation
{  
    string apiProperty = "weather_data_key";
    string jsonFilePath = "APIKeys.json";
    int zipCode = 5000; // por defecto codigo postal de ubicacion en cordoba
    string countryIsoId = "AR";
    Utilities utilities = new Utilities();
    List<string> menuOptions = new List<string>{
        " Ingrese la localidad:",
        "[ 1 ] Córdoba",
        "[ 2 ] Clorinda",
        ""
    };

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

    public void SetZipCode(int code)
    {
        zipCode = code;
    } 

    public void ResolveMenu()
    {   
        PrintMenu();
        Console.Write(" - Ingrese una opcion: ");
        string option = Console.ReadLine().ToString();
        SolveOption(option);
    }
    public void PrintMenu()
    {
        foreach (var linea in menuOptions)
        {
            Console.WriteLine(linea);
        }
    }

    public void SolveOption(string option = "")
    {
        switch (option.ToLower())
        {
            case "1": // cordoba
                zipCode = 5000; 
                break;
            case "2": // clorinda
                zipCode = 3610;
                break;
            default:
                string currentError = $"* [ ! ] La opcion ingresada [{option}] no es valida. *";
                utilities.PrintError(currentError);
                ResolveMenu(); 
                break;
        }
    }
}