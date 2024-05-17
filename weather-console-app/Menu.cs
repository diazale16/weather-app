class Menu
{
    List<string> menuOptions = new List<string>{
        " --> WEATHER FORECAST APPLICATION",
        "[ 1 ] Clima del dia",
        "[ 2 ] Clima de la semana",
        "[ Q ] Salir",
        ""
    };
    public void resolveMenu(Dashboard tablero)
    {   
        printMenu();
        string option = Console.ReadLine().ToString();
        solveOption(tablero, option);
        // return tablero;
    }
    public void printMenu()
    {
        foreach (var linea in menuOptions)
        {
            Console.WriteLine(linea);
        }
    }

    public void solveOption(Dashboard tablero, string option = "")
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
                string currentError = $" [ ! ] La opcion ingresada [{option}] no es valida.";
                string delimiter = new string('*', currentError.Length);
                List<string> errorAdvice = new List<string>{delimiter,currentError,delimiter,""};
                Console.Clear();
                errorAdvice.ForEach(Console.WriteLine);
                resolveMenu(tablero); 
                break;
        }
    }
}
    