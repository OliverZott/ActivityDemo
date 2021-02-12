using System;
using System.Runtime.CompilerServices;

// https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage

namespace DemoProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            var activityService = new ActivityService();
            activityService.LoadData();

            activityService.ShowActivities();

            /*
            var activity1 = new Activity("Skiing", 25);
            Console.WriteLine(activity1.ToString());
            // Console.ReadKey();
            */
        }
    }
}