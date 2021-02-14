using System;
using System.Collections.Generic;
using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage

namespace DemoProject1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // #nullable enable
            var activities = new List<Activity>
            {
                new Activity("Skifahren", 50),
                new Activity("Rodeln", 10),
                new Activity("Eislaufen", 5),
                new Activity("Langlaufen", 8)
            };


            foreach (var activity in activities)
            {
                var index = activities.IndexOf(activity);
                Console.WriteLine($"[{index + 1}] {activity}");
            }


            Console.WriteLine("Please select your activity (e.g. '3'): ");
            var activityIndex = Console.ReadLine();
            while (!IsInputValid(activityIndex))
            {
                Console.WriteLine("Invalid input. Please enter a proper integer value.");
                Console.WriteLine("Please select your activity: ");
                activityIndex = Console.ReadLine();
            }

            var parsedActivityIndex = int.Parse(activityIndex);


            Console.WriteLine("Please enter number of days: ");
            var activityDuration = Console.ReadLine();
            while (!IsInputValid(activityDuration, false))
            {
                Console.WriteLine("Invalid input. Please enter a proper integer value!");
                Console.WriteLine("Please select your activity (e.g. '3'): ");
                activityDuration = Console.ReadLine();
            }

            var parsedActivityDuration = int.Parse(activityDuration ?? string.Empty);


            static bool IsInputValid(string input, bool upperBorderCallback = true)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return false;
                }

                if (!int.TryParse(input, out _))
                {
                    return false;
                }

                if (int.Parse(input) < 1)
                {
                    return false;
                }

                if (upperBorderCallback && int.Parse(input) > 4)
                {
                    return false;
                }

                return true;
            }

            var chosenActivity = activities.ElementAt(parsedActivityIndex - 1);
            var chosenActivityPrice = chosenActivity.Price * parsedActivityDuration;

            Console.WriteLine($"{chosenActivity.Name} kostet {chosenActivityPrice} Euro für {parsedActivityDuration} Tage.");
        }
    }
}