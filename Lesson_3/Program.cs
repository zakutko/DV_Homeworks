namespace Lesson_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Число, отримане під час прочитання числа 456 справа наліво = {ReverseNumber(456)}");
            Console.WriteLine($"Квадрат числа 21.23 = {CalculateSquare(21.23)}");
            Console.WriteLine($"Отримане під час перестановки першої та другої цифр числа 456 = {SwapFirstAndSecondDigit(456)}");
            Console.WriteLine($"Середнє арифметичне чисел 34.12 та 76.2 = {CalculateAverage(34.12, 76.2)}");
            Console.WriteLine($"Площа круга з радіусом 167.2 дорівнює {CalculateCircleArea(167.2)}");
            Console.WriteLine("Дослідження методів заміни місцями значення двох змінних без використання тимчасової змінної:");
            int a = 5;
            int b = 1;
            Console.WriteLine($"До обміну: a = {a}, b = {b}");
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine($"Після обміну: a = {a}, b = {b}");
            Console.ReadKey();
        }

        public static int ReverseNumber(int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number /= 10;
            }
            return reversedNumber;
        }

        public static double CalculateSquare(double number)
        {
            return Math.Pow(number, 2);
        }

        public static int SwapFirstAndSecondDigit(int number)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            int swappedNumber = secondDigit * 100 + firstDigit * 10 + thirdDigit;
            return swappedNumber;
        }

        public static double CalculateAverage(double number1, double number2)
        {
            return (number1 + number2) / 2.0;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}