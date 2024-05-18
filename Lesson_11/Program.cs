using UkrainianStringLibrary;

namespace Lesson_11
{
    public class Program
    {
        public static void Main()
        {
            var sampleText = "Привіт, світ! Це тестовий рядок.";

            Console.WriteLine("Оригінальний рядок: " + sampleText);

            var vowelsCount = UkrainianStringUtils.CountVowels(sampleText);
            Console.WriteLine("Кількість голосних: " + vowelsCount);

            var consonantsCount = UkrainianStringUtils.CountConsonants(sampleText);
            Console.WriteLine("Кількість приголосних: " + consonantsCount);

            var reversedString = UkrainianStringUtils.ReverseString(sampleText);
            Console.WriteLine("Обернений рядок: " + reversedString);

            var withoutDuplicates = UkrainianStringUtils.RemoveDuplicates(sampleText);
            Console.WriteLine("Рядок без дублікатів: " + withoutDuplicates);

            var withoutPunctuation = UkrainianStringUtils.RemovePunctuation(sampleText);
            Console.WriteLine("Рядок без пунктуації: " + withoutPunctuation);

            Console.WriteLine("Завдання 2:");
            ProcessSecondTask();
        }

        public static void ProcessSecondTask()
        {
            while (true)
            {
                Console.Write("Введіть свій вік: ");
                string input = Console.ReadLine();

                try
                {
                    int age = int.Parse(input);

                    if (age < 0)
                    {
                        throw new FormatException("Вік не може бути від'ємним числом.");
                    }

                    Console.WriteLine($"Ваш вік: {age}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Невідома помилка: {ex.Message}");
                }
            }
        }
    }
}