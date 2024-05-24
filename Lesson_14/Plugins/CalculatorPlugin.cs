using Lesson_14.Interfaces;

namespace Lesson_14.Plugins
{
    public class CalculatorPlugin : IPlugin
    {
        public void Execute()
        {
            const int a = 1;
            const int b = 2;
            Console.WriteLine($"Результат арифмметичної операції {a} + {b} = {a + b}");
        }
    }
}
