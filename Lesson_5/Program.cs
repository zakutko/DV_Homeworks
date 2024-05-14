namespace Lesson_5
{
    public class Program
    {
        public static void Main()
        {
            ProcessFirstTask();
            ProcessSecondTask();
            ProcessThirdTask();

            Console.ReadKey();
        }

        public static void ProcessFirstTask()
        {
            string correctPassword = "root";
            string input;

            do
            {
                Console.WriteLine("Введіть пароль:");
                input = Console.ReadLine();

                if (input != correctPassword)
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            } while (input != correctPassword);

            Console.WriteLine("Ви увійшли в систему.");
        }

        public static void ProcessSecondTask()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 147);
            int guess;

            Console.WriteLine("Вгадайте число від 1 до 146:");

            do
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Більше.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Менше.");
                    }
                    else
                    {
                        Console.WriteLine("Вітаємо! Ви вгадали число!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
                }
            } while (true);
        }

        public static void ProcessThirdTask()
        {
            Console.WriteLine("Таблиця множення:\n");

            Console.Write("   ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,2} |");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}