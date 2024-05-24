using Lesson_14.Interfaces;
using Lesson_14.Plugins;
using Lesson_14.Utilities;

namespace Lesson_14
{
    public static class Program
    {
        public static void Main()
        {
            ProcessFirstTask();
            ProcessSecondTask();

            Console.ReadKey();
        }

        private static void ProcessFirstTask()
        {
            var pluginManager = new PluginManager();

            IPlugin calculatorPlugin = new CalculatorPlugin();
            IPlugin greetingPlugin = new GreetingPlugin();

            pluginManager.LoadPlugin(calculatorPlugin);
            pluginManager.LoadPlugin(greetingPlugin);

            pluginManager.ExecuteAll();
        }

        private static void ProcessSecondTask()
        {
            Logger.AddLog("Бажаю вам гарного дня!");
            Logger.AddLog("Дуже дякую!");

            Logger.GetLogs();
        }
    }
}