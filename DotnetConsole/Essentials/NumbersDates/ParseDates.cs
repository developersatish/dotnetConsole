using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetConsole.Essentials.NumbersDates
{
    internal class ParseDates
    {
        public static void Go()
        {
            string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

            foreach (string datestr in sampleDateTimes)
            {
                DateTime result;
                // Use the static class function TryParse to try parsing the dates
                if (DateTime.TryParse(datestr, out result))
                {
                    Console.WriteLine($"{datestr,-25} gets parsed as: {result}");
                }
                else
                {
                    Console.WriteLine($"Could not parse '{datestr}'");
                }
            }
        }
    }
}
