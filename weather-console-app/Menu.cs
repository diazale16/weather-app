class Menu
{
    Utilities utilities= new Utilities();
    List<string> menuOptions = new List<string>{
        " --> WEATHER FORECAST APPLICATION",
        "[ 1 ] Clima del dia",
        "[ 2 ] Clima de la semana",
        "[ Q ] Salir",
        ""
    };
    public void ResolveMenu(Dashboard tablero)
    {   
        PrintMenu();
        string option = Console.ReadLine().ToString();
        SolveOption(tablero, option);
        // return tablero;
    }
    public void PrintMenu()
    {
        foreach (var linea in menuOptions)
        {
            Console.WriteLine(linea);
        }
    }

    public void SolveOption(Dashboard tablero, string option = "")
    {
        switch (option.ToLower())
        {
            case "1":
                Temperature weatherDay = new Temperature();
                tablero.forecastObject = weatherDay;
                break;
            case "2":
                Forecast forecastWeek = new Forecast();
                tablero.forecastObject = forecastWeek;
                break;
            case "q":
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                string currentError = $"* [ ! ] La opcion ingresada [{option}] no es valida. *";
                utilities.PrintError(currentError);
                ResolveMenu(tablero); 
                break;
        }
    }
}
    