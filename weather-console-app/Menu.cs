using System;
class Menu
{
    List<string> menuOptions = new List<string>{
        "1- Clima del dia",
        "2- Clima de la semana",
        "'q' Salir",
        ""
    };
    public void printMenu()
    {
        foreach (var linea in menuOptions)
        {
            Console.WriteLine(linea);
        }
        String option = Console.ReadLine().ToString();
        solveOption(option);
    }

    public void solveOption(string option = "")
    {
        switch (option)
        {
            case "1":
                APILocation api = new APILocation();
                api.Main();
                break;
            case "2":
                Console.WriteLine($"opc 2"); 
                break;
            case "q":
                Environment.Exit(0);
                break;
            default: 
                Console.WriteLine($" [!] La opcion ingresa [{option}] no es valida.");
                printMenu();
                break;
        }
    }
}
    