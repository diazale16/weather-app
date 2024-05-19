using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Utilities
{   
    public string GetAPIKey(string jsonFilePath, string keyProperty)
    {
        try
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject jsonData = JObject.Parse(jsonContent);
            try
            {
                string locationAPIKey = jsonData[$"{keyProperty}"].ToString();
                return locationAPIKey;
            }
            catch (NullReferenceException)
            {
                string currentError = $"* [ ! ] No existe una clave definidia para la propiedad [{keyProperty}]. *";
                PrintError(currentError);      
                return "null";      
            }
        }
        catch (FileNotFoundException)
        {
            string currentError = $"* [ ! ] No se encontro el archivo [{jsonFilePath}]. *";
            PrintError(currentError);         
            return "null";
        }
        catch (JsonException)
        {
            string currentError = $"* [ ! ] Excepcion de JSON. *";
            PrintError(currentError); 
            return "null";
        }
    }

    public void PrintError(string error)
    {   
        string delimiter = new string('*', error.Length);
        List<string> errorAdvice = new List<string>{delimiter,error,delimiter,""};
        Console.Clear();
        errorAdvice.ForEach(Console.WriteLine);
    }
}