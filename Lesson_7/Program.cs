namespace Lesson_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            var subjects = new List<string> { "Математика", "Історія", "Мова" };
            var grades = new Dictionary<string, List<int>>();

            foreach (var subject in subjects)
            {
                grades[subject] = new List<int>();
            }

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести оцінки");
                Console.WriteLine("2. Показати оцінки");
                Console.WriteLine("3. Обчислити середню оцінку");
                Console.WriteLine("4. Вийти");
                Console.Write("Оберіть пункт меню: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterGrades(subjects, grades);
                        break;
                    case "2":
                        DisplayGrades(subjects, grades);
                        break;
                    case "3":
                        CalculateAndDisplayAverageGrades(subjects, grades);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void EnterGrades(List<string> subjects, Dictionary<string, List<int>> grades)
        {
            foreach (var subject in subjects)
            {
                Console.Write($"Введіть кількість оцінок для предмету {subject}: ");
                int count;
                while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
                {
                    Console.Write("Невірний ввід. Введіть додатнє число: ");
                }

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введіть оцінку {i + 1} для предмету {subject}: ");
                    int grade;
                    while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 12)
                    {
                        Console.Write("Невірний ввід. Введіть оцінку від 0 до 12: ");
                    }
                    grades[subject].Add(grade);
                }
            }
        }

        static void DisplayGrades(List<string> subjects, Dictionary<string, List<int>> grades)
        {
            Console.WriteLine("Оцінки студента:");
            foreach (var subject in subjects)
            {
                Console.Write($"{subject}: ");
                if (grades[subject].Count == 0)
                {
                    Console.WriteLine("Немає оцінок");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", grades[subject]));
                }
            }
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }

        static void CalculateAndDisplayAverageGrades(List<string> subjects, Dictionary<string, List<int>> grades)
        {
            Console.WriteLine("Середні оцінки студента:");
            foreach (var subject in subjects)
            {
                if (grades[subject].Count == 0)
                {
                    Console.WriteLine($"{subject}: Немає оцінок для обчислення середньої оцінки");
                }
                else
                {
                    double average = CalculateAverageGrade(grades[subject]);
                    Console.WriteLine($"{subject}: {average:F2}");
                }
            }
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }

        static double CalculateAverageGrade(List<int> grades)
        {
            int sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return (double)sum / grades.Count;
        }
    }
}