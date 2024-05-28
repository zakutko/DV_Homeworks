using Lesson_15.Utilities;
using Lesson_15.Models;

namespace Lesson_15
{
    public static class Program
    {
        public static void Main()
        {
            var shop = new Shop();
            var cart = new Cart();

            // Додаємо деякі продукти в магазин
            shop.AddProduct(new Product { Id = 1, Name = "Яблуко", Price = 0.5 });
            shop.AddProduct(new Product { Id = 2, Name = "Банан", Price = 0.2 });
            shop.AddProduct(new Product { Id = 3, Name = "Молоко", Price = 1.5 });
            shop.AddProduct(new Product { Id = 4, Name = "Хліб", Price = 1.0 });

            var running = true;

            while (running)
            {
                Console.WriteLine("Ласкаво просимо до магазину! Будь ласка, виберіть опцію:");
                Console.WriteLine("1. Переглянути всі продукти");
                Console.WriteLine("2. Додати продукт до кошика");
                Console.WriteLine("3. Видалити продукт з кошика");
                Console.WriteLine("4. Переглянути загальну вартість у кошику");
                Console.WriteLine("5. Вийти");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Продукти, доступні в магазині:");

                        foreach (var product in shop.GetAllProducts())
                        {
                            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Ціна: {product.Price}");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Введіть ID продукту, щоб додати до кошика:");

                        int productIdToAdd;

                        if (int.TryParse(Console.ReadLine(), out productIdToAdd))
                        {
                            var product = shop.GetProductById(productIdToAdd);

                            if (product != null)
                            {
                                cart.AddToCart(product);
                                Console.WriteLine($"{product.Name} додано до кошика.");
                            }
                            else
                            {
                                Console.WriteLine("Продукт не знайдено.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Невірний ввід.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Введіть ID продукту, щоб видалити з кошика:");

                        int productIdToRemove;

                        if (int.TryParse(Console.ReadLine(), out productIdToRemove))
                        {
                            cart.RemoveFromCart(productIdToRemove);
                            Console.WriteLine("Продукт видалено з кошика.");
                        }
                        else
                        {
                            Console.WriteLine("Невірний ввід.");
                        }
                        break;

                    case "4":
                        Console.WriteLine($"Загальна вартість у кошику: {cart.GetTotalPrice()}");
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}