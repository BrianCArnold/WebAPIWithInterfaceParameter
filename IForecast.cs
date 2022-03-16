namespace WebAPIWithInterface;

[DefaultImplementation(typeof(WeatherForecast))]
public interface IForecast
{
    string? Summary { get; set; }
    int JulianDate { get; set; }
    double Temperature { get; set; }
}