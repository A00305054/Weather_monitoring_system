using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_monitoring_system_library;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Represents a display for weather statistics.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private WeatherData weatherData;
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsDisplay"/> class with the specified <see cref="WeatherData"/>.
        /// </summary>
        /// <param name="weatherData">The weather data to display statistics for.</param>

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events
        }
        /// <summary>
        /// Displays weather statistics.
        /// </summary>
        public void Display()
        {
            int[] temperatures = weatherData.GetTemperatureHistory();

            if (temperatures.Length == 0)
            {
                Console.WriteLine("No weather data available for statistics.");
                return;
            }

            // Calculate statistics
            int totalTemperature = 0;
            int maxTemperature = int.MinValue;
            int minTemperature = int.MaxValue;

            foreach (int temperature in temperatures)
            {
                totalTemperature += temperature;
                maxTemperature = Math.Max(maxTemperature, temperature);
                minTemperature = Math.Min(minTemperature, temperature);
            }

            double averageTemperature = (double)totalTemperature / temperatures.Length;

            // Display statistics
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature: {averageTemperature:F1}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");

            Console.WriteLine();

           
        }
    }
}