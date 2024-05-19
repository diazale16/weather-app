
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class CoordDaily
{
    public double Lon { get; set; }
    public double Lat { get; set; }
}

public class WeatherDaily
{
    public int Id { get; set; }
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class MainDaily
{
    public double Temp { get; set; }
    public double FeelsLike { get; set; }
    public double TempMin { get; set; }
    public double TempMax { get; set; }
    public int Pressure { get; set; }
    public int Humidity { get; set; }
}

public class WindDaily
{
    public double Speed { get; set; }
    public int Deg { get; set; }
    public double Gust { get; set; }
}

public class CloudsDaily
{
    public int All { get; set; }
}

public class SysDaily
{
    public int Type { get; set; }
    public int Id { get; set; }
    public string Country { get; set; }
    public long Sunrise { get; set; }
    public long Sunset { get; set; }
}

public class WeatherResponseDaily
{
    public CoordDaily Coord { get; set; }
    public List<WeatherDaily> Weather { get; set; }
    public string Base { get; set; }
    public MainDaily Main { get; set; }
    public int Visibility { get; set; }
    public WindDaily Wind { get; set; }
    public CloudsDaily Clouds { get; set; }
    public long Dt { get; set; }
    public SysDaily Sys { get; set; }
    public int Timezone { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Cod { get; set; }

    public void PrintData()
    {   
        DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
        string s = dateOnly.ToString("yyyy-M-dd", CultureInfo.InvariantCulture);
        string header =         $" -> Clima para: {Name} ({Coord.Lat},{Coord.Lon}) para la fecha {s}";
        string skyState =       $"    - Estado del cielo: {Weather[0].Description}";
        string temperaturas =   $"    - Temperatura: {Main.Temp} C°";
        string humedad =        $"    - Humedad: {Main.Humidity}%";
        string viento =         $"    - Viento: {Wind.Speed} km/h";
        List<string> listaPrint = [header, skyState, temperaturas, humedad, viento];
        int maxLength = listaPrint.Max(x => x.Length);
        string delimiter = new string('*', maxLength);

        Console.Clear(); 
        Console.WriteLine($"{delimiter}");
        listaPrint.ForEach(Console.WriteLine);
        Console.WriteLine($"{delimiter}");
        Console.WriteLine("");
        Console.Write("Pulse cualquier tecla para continuar."); Console.ReadLine();
    }
}


