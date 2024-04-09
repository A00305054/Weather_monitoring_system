using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system_library
{
    /// <summary>
    /// Interface for display objects in the weather monitoring system.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Method to display weather information.
        /// </summary>
        void Display();
    }
}