using Lesson_10.Models;
using System.Text;

namespace Lesson_10
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Завдання 1:");
            var person1 = new Person("Олексій", 25, "чоловік");
            var person2 = new Person("Марія");
            var person3 = new Person("Іван", 17);

            person1.PrintDetails();
            person2.PrintDetails();
            person3.PrintDetails();

            Console.WriteLine($"{person1.Name} є повнолітнім: {person1.IsAdult()}");
            Console.WriteLine($"{person3.Name} є повнолітнім: {person3.IsAdult()}");

            person2.ChangeName("Олена");
            person2.PrintDetails();
            Console.WriteLine();

            Console.WriteLine("Завдання 2:");
            var day = GetValidInput("Введіть день: ", 1, 31);
            var month = GetValidInput("Введіть місяць: ", 1, 12);
            var year = GetValidInput("Введіть рік: ", 1, int.MaxValue);

            if (IsValidDate(day, month, year))
            {
                var dateBuilder = new StringBuilder();
                dateBuilder.Append(day.ToString("D2"))
                           .Append("-")
                           .Append(month.ToString("D2"))
                           .Append("-")
                           .Append(year);

                Console.WriteLine($"Дата: {dateBuilder.ToString()}");
            }
            else
            {
                Console.WriteLine("Некоректна дата.");
            }
        }

        public static int GetValidInput(string prompt, int minValue, int maxValue)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
                {
                    break;
                }
                Console.WriteLine($"Будь ласка, введіть число від {minValue} до {maxValue}.");
            }
            return value;
        }

        public static bool IsValidDate(int day, int month, int year)
        {
            try
            {
                var date = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}