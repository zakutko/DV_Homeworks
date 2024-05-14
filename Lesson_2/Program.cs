public class Program
{
    public static void Main()
    {
        var discountValue = CalculateDiscountValue(1500.23, 25);
        var totalSeconds = CalculateTotalSeconds(3, 25, 10);
        var bookInfomation = GenerateBookInformation("Кайдашева сім'я", "Іван Нечуй-Левицький", 1967, 150.99);

        Console.WriteLine($"Обчислена величина знижки: {discountValue}.");
        Console.WriteLine($"Обчислена час в секундах: {totalSeconds}с.");
        Console.WriteLine("Інформація про книгу");
        Console.WriteLine(bookInfomation);
        Console.ReadKey();
    }

    public static double CalculateDiscountValue(double price, double discountPercent)
    {
        return price * (discountPercent / 100);
    }

    public static int CalculateTotalSeconds(int hours, int minutes, int seconds)
    {
        return hours * 3600 + minutes * 60 + seconds;
    }

    public static string GenerateBookInformation(string title, string author, int year, double price)
    {
        return String.Format("Назва: {0}\nАвтор: {1}\nРік: {2}\nЦіна: {3:C}", title, author, year, price);
    }
}