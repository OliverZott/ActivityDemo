using ActivityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ActivityDemo
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
#nullable enable

            //
            // Initialising example activity list
            //
            var activities = new List<Activity>
            {
                new Activity("Skifahren", 50),
                new Activity("Rodeln", 10),
                new Activity("Eislaufen", 5),
                new Activity("Langlaufen", 8)
            };

            var listLength = activities.Count;


            //
            // I/O for user interaction
            //
            foreach (var activity in activities)
            {
                var index = activities.IndexOf(activity);
                Console.WriteLine($"[{index + 1}] {activity}");
            }

            Console.WriteLine("Please select your activity (e.g. '3'): ");
            var activityIndex = Console.ReadLine();
            while (!InputValidation.IsInputValid(activityIndex, listLength))
            {
                Console.WriteLine("Invalid input. Please enter a proper integer value.");
                Console.WriteLine("Please select your activity: ");
                activityIndex = Console.ReadLine();
            }
            var parsedActivityIndex = int.Parse(activityIndex);

            Console.WriteLine("Please enter number of days: ");
            var activityDuration = Console.ReadLine();
            while (!InputValidation.IsInputValid(activityDuration, listLength, false))
            {
                Console.WriteLine("Invalid input. Please enter a proper integer value!");
                Console.WriteLine("Please select your activity (e.g. '3'): ");
                activityDuration = Console.ReadLine();
            }
            var parsedActivityDuration = int.Parse(activityDuration ?? string.Empty);


            //
            // Final output
            //
            var chosenActivity = activities.ElementAt(parsedActivityIndex - 1);
            var chosenActivityPrice = chosenActivity.Price * parsedActivityDuration;

            Console.WriteLine($">> {parsedActivityDuration} Tage {chosenActivity.Name} kosten {chosenActivityPrice} Euro.");
        }
    }
}