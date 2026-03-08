namespace GIT_UIT
{
    // modified This is a simple class representing a weather forecast with properties for date, temperature in Celsius, temperature in Fahrenheit, and a summary description.
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
