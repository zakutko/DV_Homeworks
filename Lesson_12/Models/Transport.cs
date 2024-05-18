namespace Lesson_12.Models
{
    public class Transport
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public Transport(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves at a speed of up to {MaxSpeed} km/h.");
        }
    }
}
