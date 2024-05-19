using System;
using System.Collections.Generic;
using System.Globalization;

public class MainWeekly
{
    public double Temp { get; set; }
    public double FeelsLike { get; set; }
    public double TempMin { get; set; }
    public double TempMax { get; set; }
    public int Pressure { get; set; }
    public int SeaLevel { get; set; }
    public int GrndLevel { get; set; }
    public int Humidity { get; set; }
    public double TempKf { get; set; }
}

public class WeatherWeekly
{
    public int Id { get; set; }
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class CloudsWeekly
{
    public int All { get; set; }
}

public class WindWeekly
{
    public double Speed { get; set; }
    public int Deg { get; set; }
    public double Gust { get; set; }
}

public class SysWeekly
{
    public string Pod { get; set; }
}

public class WeatherItemWeekly
{
    public long Dt { get; set; }
    public MainWeekly Main { get; set; }
    public List<WeatherWeekly> Weather { get; set; }
    public CloudsWeekly Clouds { get; set; }
    public WindWeekly Wind { get; set; }
    public int Visibility { get; set; }
    public double Pop { get; set; }
    public SysWeekly Sys { get; set; }
    public string Dt_Txt { get; set; }
}

public class WeatherResponseWeekly
{
    public string Cod { get; set; }
    public int Message { get; set; }
    public int Cnt { get; set; }
    public List<WeatherItemWeekly> List { get; set; }

    public void PrintData()
    {
        List<List<string>> listaPrint = new List<List<string>>();
        List<string> fechas = new List<string>();
        DateOnly fechaHoy = DateOnly.FromDateTime(DateTime.Now);

        Console.Clear();
        for (var i = 0; i < 5; i++)
        {
            fechaHoy = fechaHoy.AddDays(1);
            fechas.Add($"{fechaHoy.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)} 12:00:00");
        }
        foreach (var item in List)
        {
            if (fechas.Contains(item.Dt_Txt)) 
            {
                string header =     $" -> Clima para: {item.Dt_Txt.Split(" ")[0]}";
                string skyState =   $"    - Estado del cielo: {item.Weather[0].Description}";
                string temp =       $"    - Temperatura: {item.Main.Temp} C°";
                string hum =        $"    - Humedad: {item.Main.Humidity}%";
                string viento =     $"    - Viento: {item.Wind.Speed} km/h";
                List<string> listaItem = [header, skyState, temp, hum, viento];
                listaPrint.Add(listaItem);
            }
        }
        foreach (var item in listaPrint)
        {
            item.ForEach(Console.WriteLine);
            Console.ReadLine(); // Console.Write("Pulse cualquier tecla para continuar al siguiente dia."); 
        }
        Console.Write("Pulse cualquier tecla para continuar."); Console.ReadLine();
    } 
}
