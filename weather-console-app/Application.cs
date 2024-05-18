public class Application
{
    Menu menu = new Menu();
    Dashboard tablero = new Dashboard();
    Dictionary<string, double> coordenadas = new Dictionary<string, double>();
    public void Run()
    {
        coordenadas = SetCoordenadas();
        tablero.coordenadas = coordenadas;
        
        while (true)
        {
            // mostrar menu y tomar entrada
            // tablero = 
            Console.Clear();
            menu.ResolveMenu(tablero);
            tablero.UpdateForescast(); 
        }   
         
    }

    public static Dictionary<string, double> SetCoordenadas()
    {   
        APILocation location = new APILocation();
        Dictionary<string, double> coordenadas = location.Main();
        return coordenadas;
    }
}