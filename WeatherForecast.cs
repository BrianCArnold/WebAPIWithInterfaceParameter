using System.Runtime.InteropServices;

namespace WebAPIWithInterface;

public class WeatherForecast : IForecast
{
    public string? Summary { get; set; }
    public int JulianDate { get; set; }
    public double Temperature { get; set; }
}
