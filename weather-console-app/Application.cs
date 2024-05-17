public class Application
{
    Menu menu = new Menu();
    Dashboard tablero = new Dashboard();
    Dictionary<string, double> coordenadas = new Dictionary<string, double>();
    public void Run()
    {
        coordenadas = setCoordenadas();
        tablero.coordenadas = coordenadas;
        
        while (true)
        {
            // mostrar menu y tomar entrada
            // tablero = 
            Console.Clear();
            menu.resolveMenu(tablero);
            tablero.updateForescast();
            
        }    
    }

    public static Dictionary<string, double> setCoordenadas()
    {   
        APILocation location = new APILocation();
        Dictionary<string, double> coordenadas = location.Main();
        return coordenadas;
    }
}