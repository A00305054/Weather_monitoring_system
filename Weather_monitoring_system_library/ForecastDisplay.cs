using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Represents a display for weather forecast information.
    /// </summary>
    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;
        /// <summary>
        /// Initializes a new instance of the ForecastDisplay class with the specified WeatherData instance.
        /// </summary>
        /// <param name="weatherData">The WeatherData instance to get weather information from.</param>


        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events
        }
        /// <summary>
        /// Displays the weather forecast.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Weather Forecast:");
            Console.WriteLine("Weather Forecast:");

            // Implement logic to generate and display weather forecast based on current weather data
            // Example forecast logic based on temperature
            if (weatherData.Temperature < 0)
            {
                Console.WriteLine("freezing with a potential for ice or snow");
            }
            else if (weatherData.Temperature < 10)
            {
                Console.WriteLine("A cold day with a potential of snow showers or rain.");
            }
            else if (weatherData.Temperature < 20)
            {
                Console.WriteLine("Cool with a slight probability of small bouts of rain");
            }
            else if (weatherData.Temperature < 30)
            {
                Console.WriteLine("Temperate with a possible sun");
            }
            else
            {
                Console.WriteLine("Warm with a clear sky");
            }

            Console.WriteLine();
        }
    }
}