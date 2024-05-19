using Newtonsoft.Json.Linq;

public class Application
{
    Menu menu = new Menu();
    // Dashboard tablero = new Dashboard();
    // JObject cordsData = new JObject();
    public void Run()
    {
        JObject cordsData = SetCoordenadas();
        Coordenadas coords = new Coordenadas()
        {
            latitud = (double)cordsData["lat"],
            longitud = (double)cordsData["lon"],
        };
        Dashboard tablero = new Dashboard()
        {
            coordenadas = coords
        };
        
        while (true)
        {
            // mostrar menu y tomar entrada
            // tablero = 
            Console.Clear();
            menu.ResolveMenu(tablero);
            dynamic weatherResponseObject = tablero.UpdateForescast();
            weatherResponseObject.PrintData();
        }   
    }

    public static JObject SetCoordenadas()
    {   
        APILocation apiLocacion = new APILocation();
        JObject coordenadas = apiLocacion.Main();
        return coordenadas;
    }
}