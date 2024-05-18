namespace Lesson_12.Models
{
    public class Bicycle : Transport
    {
        public string BicycleType { get; set; }

        public Bicycle(string name, int maxSpeed, string bicycleType)
            : base(name, maxSpeed)
        {
            BicycleType = bicycleType;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} (bicycle) moves at a speed of up to {MaxSpeed} km/h. It is a {BicycleType} bicycle.");
        }
    }
}
