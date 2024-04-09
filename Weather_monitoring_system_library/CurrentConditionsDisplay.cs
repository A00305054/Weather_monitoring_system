using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Represents a display for current weather conditions.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private WeatherData weatherData;
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditionsDisplay"/> class.
        /// </summary>
        /// <param name="weatherData">The weather data object.</param>

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }
        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current Weather Conditions:");
            Console.WriteLine($"Temperature: {weatherData.Temperature}°C");
            Console.WriteLine($"Humidity: {weatherData.Humidity}%");
            Console.WriteLine($"Wind Speed: {weatherData.WindSpeed} km/h");
            Console.WriteLine();
        }
    }
}