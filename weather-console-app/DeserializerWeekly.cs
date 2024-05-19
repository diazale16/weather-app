using System;
using System.Collections.Generic;

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
    public string DtTxt { get; set; }
}

public class WeatherResponseWeekly
{
    public string Cod { get; set; }
    public int Message { get; set; }
    public int Cnt { get; set; }
    public List<WeatherItemWeekly> List { get; set; }
}
