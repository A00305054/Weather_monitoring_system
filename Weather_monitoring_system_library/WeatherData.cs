using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Represents a singleton class for managing weather data.
    /// </summary>
    public class WeatherData
    {
        private static WeatherData? instance;
        private Random random;
        private List<int> temperatureHistory;
        /// <summary>
        /// Private constructor to prevent external instantiation.
        /// </summary>
        private WeatherData()
        {
            random = new Random();
            temperatureHistory = new List<int>();
        }
        /// <summary>
        /// Gets the singleton instance of the WeatherData class.
        /// </summary>
        public static WeatherData Instance
        {
            get
            {
                if (instance == null)
                    instance = new WeatherData();
                return instance;
            }
        }

        // Properties to hold weather data (temperature, humidity, wind speed, etc.)
        /// <summary>
        /// Gets the current temperature.
        /// </summary>
        public int Temperature { get; private set; }
        /// <summary>
        /// Gets the current humidity.
        /// </summary
        public int Humidity { get; private set; }
        /// <summary>
        /// Gets the current wind speed.
        /// </summary>
        public int WindSpeed { get; private set; }

        // Method to update weather data and notify observers
        /// <summary>
        /// Updates the weather data with random values and notifies observers.
        /// </summary>
        public void UpdateWeatherData()
        {
            // Generate random values for temperature, humidity, and wind speed
            Temperature = random.Next(-20, 40); // Random temperature between -20°C and 40°C
            Humidity = random.Next(0, 101); // Random humidity between 0% and 100%
            WindSpeed = random.Next(0, 101); // Random wind speed between 0 km/h and 100 km/h

            // Add current temperature to history
            temperatureHistory.Add(Temperature);

            // Notify observers (display objects) about the weather data change
            NotifyObservers();
        }
        /// <summary>
        /// Retrieves the temperature history.
        /// </summary>
        /// <returns>An array of integers representing the temperature history.</returns>
        // Method to retrieve temperature history
        public int[] GetTemperatureHistory()
        {
            return temperatureHistory.ToArray();
        }

        // Method to notify observers
        /// <summary>
        /// Notifies observers about the weather data change.
        /// </summary>
        private void NotifyObservers()
        {
            // Implementation to notify observers
        }
    }
}