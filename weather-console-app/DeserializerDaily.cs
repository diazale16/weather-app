
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
}
