namespace Lesson_8
{
    public class Program
    {
        public enum ProductType
        {
            Food,
            Clothing,
            Electronics,
            Books
        }

        public class Product
        {
            public ProductType Type { get; set; }
            public decimal Price { get; set; }

            public Product(ProductType type, decimal price)
            {
                Type = type;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Type} - {Price:C2}";
            }
        }

        public static void Main(string[] args)
        {
            var cart = new List<Product>();
            var shopping = true;

            while (shopping)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Додати новий товар");
                Console.WriteLine("2. Завершити введення і показати рахунок");
                Console.Write("Оберіть пункт меню: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProductToCart(cart);
                        break;
                    case "2":
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                }
            }

            DisplayCartSummary(cart);
        }

        public static void AddProductToCart(List<Product> cart)
        {
            Console.WriteLine("Оберіть тип товару:");
            foreach (var type in Enum.GetValues(typeof(ProductType)))
            {
                Console.WriteLine($"{(int)type}. {type}");
            }

            int productTypeChoice;
            while (!int.TryParse(Console.ReadLine(), out productTypeChoice) || !Enum.IsDefined(typeof(ProductType), productTypeChoice))
            {
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            }

            ProductType productType = (ProductType)productTypeChoice;

            Console.Write("Введіть ціну товару: ");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Невірний ввід. Введіть додатнє число для ціни.");
            }

            cart.Add(new Product(productType, price));
            Console.WriteLine("Товар додано до кошика.");
            Console.WriteLine($"Загальна вартість товарів у кошику: {CalculateTotal(cart):C2}");
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }

        public static decimal CalculateTotal(List<Product> cart)
        {
            decimal total = 0;
            foreach (var product in cart)
            {
                total += product.Price;
            }
            return total;
        }

        public static void DisplayCartSummary(List<Product> cart)
        {
            Console.Clear();
            Console.WriteLine("Рахунок:");
            foreach (var product in cart)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Загальна вартість: {CalculateTotal(cart):C2}");
            Console.WriteLine("Натисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}