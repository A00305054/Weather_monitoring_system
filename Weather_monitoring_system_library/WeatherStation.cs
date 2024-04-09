using System;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Represents a weather station that creates display objects based on the given display type.
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// Creates a display object based on the specified display type.
        /// </summary>
        /// <param name="displayType">The type of display to create (e.g., "CurrentConditions", "Statistics", "Forecast").</param>
        /// <returns>The created display object implementing the IDisplay interface.</returns>
        public IDisplay CreateDisplay(string displayType)
        {
            WeatherData weatherData = WeatherData.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditionsDisplay(weatherData);
                case "Statistics":
                    return new StatisticsDisplay(weatherData);
                case "Forecast":
                    return new ForecastDisplay(weatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}