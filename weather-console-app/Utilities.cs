using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Utilities
{   
    public string getAPIKey(string jsonFilePath, string keyProperty)
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
                string currentError = $" [ ! ] No existe una clave definidia para la propiedad [{keyProperty}].";
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
}