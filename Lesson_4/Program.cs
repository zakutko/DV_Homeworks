namespace Lesson_4
{
    public class Program
    {
        public static void Main()
        {
            ProcessFirstTask();
            ProcessSecondTask();
            ProcessThirdTask();
            ProcessFourthTask();

            Console.ReadKey();
        }

        public static void ProcessFirstTask()
        {
            Console.WriteLine("Введіть перше число:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введіть друге число:");
            string input2 = Console.ReadLine();

            double number1, number2;
            if (double.TryParse(input1, out number1) && double.TryParse(input2, out number2))
            {
                if (number1 == number2)
                {
                    Console.WriteLine($"Числа {number1} і {number2} рівні між собою.");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine($"Число {number1} менше за число {number2}.");
                }
                else
                {
                    Console.WriteLine($"Число {number1} більше за число {number2}.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення. Будь ласка, введіть числа.");
            }
        }

        public static void ProcessSecondTask()
        {
            Console.WriteLine("Введіть номер місяця:");
            string input = Console.ReadLine();

            int month;
            if (int.TryParse(input, out month))
            {
                switch (month)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Зима");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Весна");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Літо");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Осінь");
                        break;
                    default:
                        Console.WriteLine("Немає такого місяця на цій планеті");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число від 1 до 12.");
            }
        }

        public static void ProcessThirdTask()
        {
            Console.WriteLine("Введіть число від 1 до 100:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= 1 && number <= 100)
                {
                    if (number % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    Console.WriteLine("Число повинно бути від 1 до 100.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
            }
        }

        public static void ProcessFourthTask()
        {
            double a, b, c;
            GenerateRandomCoefficients(out a, out b, out c);
            Console.WriteLine($"Рівняння: {a}x^2 + {b}x + {c} = 0");

            double discriminant = CalculateDiscriminant(a, b, c);
            Console.WriteLine($"Дискримінант: D = {discriminant}");

            if (discriminant < 0)
            {
                Console.WriteLine("Рівняння не має коренів.");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("Рівняння має один корінь.");
                double root = -b / (2 * a);
                Console.WriteLine($"Корінь: x = {root}");
            }
            else
            {
                Console.WriteLine("Рівняння має два корені.");
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корінь 1: x1 = {root1}");
                Console.WriteLine($"Корінь 2: x2 = {root2}");
            }
        }

        public static void GenerateRandomCoefficients(out double a, out double b, out double c)
        {
            Random rand = new Random();
            a = rand.Next(-10, 11);
            b = rand.Next(-10, 11);
            c = rand.Next(-10, 11);
        }

        public static double CalculateDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}