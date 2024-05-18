namespace Lesson_12.Models
{
    public class Car : Transport
    {
        public int NumberOfDoors { get; set; }

        public Car(string name, int maxSpeed, int numberOfDoors)
            : base(name, maxSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} (car) moves at a speed of up to {MaxSpeed} km/h. It has {NumberOfDoors} doors.");
        }
    }
}
