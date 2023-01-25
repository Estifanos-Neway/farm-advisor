namespace FarmAdvisor.Models
{
    public class OneDayWeatherForecast
    {
        public string Date { get; set; } = null!;
        public double Temperature { get; set; }
        public double GDD { get; set; }
    }
}