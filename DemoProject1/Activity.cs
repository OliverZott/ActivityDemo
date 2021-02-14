namespace DemoProject1
{
    public class Activity
    {
        public string Name { get; set; }
        public int Price { get; set;  }

        public Activity(string activityName, int price)
        {
            Name = activityName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - Euro {Price} pro Tag";
        }
    }
}