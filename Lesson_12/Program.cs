using Lesson_12.Models;

namespace Lesson_12
{
    public class Program
    {
        public static void Main()
        {
            var car = new Car("Toyota Camry", 240, 4);
            car.Move();

            var bicycle = new Bicycle("Giant", 30, "mountain");
            bicycle.Move();

            Console.ReadKey();
        }
    }
}