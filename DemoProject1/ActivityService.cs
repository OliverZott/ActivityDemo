using System;
using System.Collections.Generic;

namespace DemoProject1
{
    public class ActivityService
    {
        
        
        private List<Activity> activities;

        public ActivityService()
        {
            this.activities = new List<Activity>();
        }

        public List<Activity> LoadData()
        {
            activities?.Add(new Activity("Skifahren", 50));
            activities?.Add(new Activity("Rodeln", 10));
            activities?.Add(new Activity("Eislaufen", 5));
            activities?.Add(new Activity("Langlaufen", 8));

            return activities;
        }

        public void ShowActivities()
        {
            foreach (var activity in activities)
            {
                // Console.WriteLine($"[{activities.FindIndex()}] {activity.ToString()}");
                Console.WriteLine(activity.ToString());
            }
        }
    }
}