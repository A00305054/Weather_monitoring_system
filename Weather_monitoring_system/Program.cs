using System;
using Weather_monitoring_system_library;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// The main class containing the entry point for the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method of the application.
        /// </summary>
       /// <param name="args">Command-line arguments.</param>

        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            /// <summary>
            /// Creates a display object based on the specified type.
            /// </summary>

            // Create display objects
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
            /// <summary>
            /// Creates a display object based on the specified type.
            /// </summary>
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
            /// <summary>
            /// Creates a display object based on the specified type.
            /// </summary>
            IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

            // Update weather data multiple times to generate temperature history
            for (int i = 0; i < 10; i++)
            {
                WeatherData.Instance.UpdateWeatherData();
            }

            // Update weather data
            WeatherData.Instance.UpdateWeatherData();
            /// <summary>
            /// Displays the current weather conditions.
            /// </summary>

            // Display weather data
            currentConditionsDisplay.Display();
            /// <summary>
            /// Displays the weather statistics.
            /// </summary>
            statisticsDisplay.Display();
            /// <summary>
            /// Displays the weather forecast.
            /// </summary>
            forecastDisplay.Display();
        }
    }
}