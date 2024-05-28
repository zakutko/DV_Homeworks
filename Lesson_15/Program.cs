using Lesson_15.Utilities;
using Lesson_15.Models;

namespace Lesson_15
{
    public static class Program
    {
        public static void Main()
        {
            ProcessFirstTask();
            ProcessSecondTask();
            Console.ReadKey();
        }

        public static void ProcessFirstTask()
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

        public static void ProcessSecondTask()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Каталог контактів:");
                Console.WriteLine("1. Додати новий контакт");
                Console.WriteLine("2. Видалити контакт за іменем");
                Console.WriteLine("3. Оновити номер телефону існуючого контакту");
                Console.WriteLine("4. Шукати контакт за іменем");
                Console.WriteLine("5. Вивести список усіх контактів");
                Console.WriteLine("6. Вийти");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact(contacts);
                        break;

                    case "2":
                        RemoveContact(contacts);
                        break;

                    case "3":
                        UpdateContact(contacts);
                        break;

                    case "4":
                        SearchContact(contacts);
                        break;

                    case "5":
                        ListContacts(contacts);
                        break;

                    case "6":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                        break;
                }

                Console.WriteLine();
            }

            static void AddContact(Dictionary<string, string> contacts)
            {
                Console.WriteLine("Введіть ім'я нового контакту:");
                var name = Console.ReadLine();

                if (contacts.ContainsKey(name))
                {
                    Console.WriteLine("Контакт з таким ім'ям вже існує.");
                }
                else
                {
                    Console.WriteLine("Введіть номер телефону:");
                    string phoneNumber = Console.ReadLine();
                    contacts.Add(name, phoneNumber);
                    Console.WriteLine("Контакт додано.");
                }
            }

            static void RemoveContact(Dictionary<string, string> contacts)
            {
                Console.WriteLine("Введіть ім'я контакту, який потрібно видалити:");
                var name = Console.ReadLine();

                if (contacts.Remove(name))
                {
                    Console.WriteLine("Контакт видалено.");
                }
                else
                {
                    Console.WriteLine("Контакт не знайдено.");
                }
            }

            static void UpdateContact(Dictionary<string, string> contacts)
            {
                Console.WriteLine("Введіть ім'я контакту, номер телефону якого потрібно оновити:");
                string name = Console.ReadLine();

                if (contacts.ContainsKey(name))
                {
                    Console.WriteLine("Введіть новий номер телефону:");
                    string newPhoneNumber = Console.ReadLine();
                    contacts[name] = newPhoneNumber;
                    Console.WriteLine("Номер телефону оновлено.");
                }
                else
                {
                    Console.WriteLine("Контакт не знайдено.");
                }
            }

            static void SearchContact(Dictionary<string, string> contacts)
            {
                Console.WriteLine("Введіть ім'я контакту, який потрібно знайти:");
                string name = Console.ReadLine();

                if (contacts.TryGetValue(name, out string phoneNumber))
                {
                    Console.WriteLine($"Ім'я: {name}, Номер телефону: {phoneNumber}");
                }
                else
                {
                    Console.WriteLine("Контакт не знайдено.");
                }
            }

            static void ListContacts(Dictionary<string, string> contacts)
            {
                Console.WriteLine("Список усіх контактів:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Ім'я: {contact.Key}, Номер телефону: {contact.Value}");
                }
            }
        }
    }
}