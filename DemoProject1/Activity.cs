namespace DemoProject1
{
    public class Activity
    {
        private string ActivityName { get; set; }
        private int Price { get; set; }

        public Activity(string activityName, int price)
        {
            ActivityName = activityName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ActivityName}, {nameof(Price)}: {Price}.- Euro";
        }
    }
}