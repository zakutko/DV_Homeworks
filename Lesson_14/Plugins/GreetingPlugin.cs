using Lesson_14.Interfaces;

namespace Lesson_14.Plugins
{
    public class GreetingPlugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Вітаємо! Це повідомлення від плагіна GreetingPlugin.");
        }
    }
}
