using Lesson_14.Models;

namespace Lesson_14.Utilities
{
    public static class Logger
    {
        private static readonly List<LogEntry> _logs = new List<LogEntry>();

        public static void AddLog(string message)
        {
            _logs.Add(new LogEntry
            {
                Timestamp = DateTime.Now,
                Message = message
            });
        }

        public static void GetLogs()
        {
            _logs.ForEach(log =>
            {
                Console.WriteLine($"{log.Timestamp}: {log.Message}");
            });
        }
    }
}
