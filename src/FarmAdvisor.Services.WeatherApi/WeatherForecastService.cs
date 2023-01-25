using Newtonsoft.Json;
// using static System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using FarmAdvisor.Models;

namespace FarmAdvisor.Services.WeatherApi
{

    public class ForecastApiResponse
    {
        public class Properties
        {
            public class TimeSeriesPoint
            {

                public class TimeSeriesPointData
                {
                    public class TimeSeriesPointDataInstant
                    {
                        public class TimeSeriesPointDataInstantDetails
                        {
                            public double air_pressure_at_sea_level;
                            public double air_temperature;
                            public double cloud_area_fraction;
                            public double relative_humidity;
                            public double wind_from_direction;
                            public double wind_speed;
                        }
                        public TimeSeriesPointDataInstantDetails details = null!;
                    }
                    public class NextHours
                    {
                        public class NextHoursSummary
                        {
                            public string symbol_code = null!;
                        }
                        public class NextHoursDetails
                        {
                            public string symbol_code = null!;
                        }
                        public NextHoursSummary summary = null!;
                        public NextHoursDetails? details;
                    }
                    public TimeSeriesPointDataInstant instant = null!;
                    public NextHours? next_12_hours;
                    public NextHours? next_1_hours;
                    public NextHours? next_6_hours;
                }
                public string time = null!;
                public TimeSeriesPointData data = null!;
            }
            public TimeSeriesPoint[] timeseries = null!;
        }
        public Properties properties = null!;
    }
    public class WeatherForecastService
    {
        private readonly HttpClient client = new HttpClient();
        public WeatherForecastService()
        {

            client.DefaultRequestHeaders.Add("User-Agent", "C# program");
        }
        public async Task<List<OneDayWeatherForecast>> getForecastAsync(int altitude, double latitude, double longitude)
        {
            var fetchedForecast = await client.GetStringAsync(" https://api.met.no/weatherapi/locationforecast/2.0/compact?altitude=" + altitude + "&lat=" + latitude + "&lon=" + longitude);
            ForecastApiResponse fetchedForecastJson = JsonConvert.DeserializeObject<ForecastApiResponse>(fetchedForecast)!;
            List<OneDayWeatherForecast> forecasts = new List<OneDayWeatherForecast>();
            forecasts.Add(new OneDayWeatherForecast()
            {
                Date = fetchedForecastJson.properties.timeseries[0].data.next_6_hours!.summary.symbol_code
            });
            return forecasts;
        }
    }
}