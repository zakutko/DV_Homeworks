using Lesson_16.Models;

namespace Lesson_16
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Завдання 1:");
            GetFilteredNumbers(new List<int> { 2, 5, 8, 12, 15, 18, 22 });
            Console.WriteLine("Завдання 2:");
            GetSortedFruits(new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" });
            Console.WriteLine("Завдання 3:");
            GetUniqueStrings(new List<string> { "А", "Б", "В", "А", "Г", "В" });
            Console.WriteLine("Завдання 4:");
            GetCountOfStudents(new List<int> { 85, 92, 78, 95, 88, 90 });
            Console.WriteLine("Завдання 5:");
            GetFilteredAndSortedProducts(new List<Product>
            {
                new Product { Name = "Товар1", Price = 45 },
                new Product { Name = "Товар2", Price = 60 },
                new Product { Name = "Товар3", Price = 30 },
                new Product { Name = "Товар4", Price = 50 },
                new Product { Name = "Товар5", Price = 20 }
            });
            Console.WriteLine("Завдання 6:");
            GetMaxIndexAndMaxValue(new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 });

            Console.WriteLine("*Завдання 7:");

            var students = new List<Student>
            {
                new Student { Name = "Олена", Grade = 95, Course = 1 },
                new Student { Name = "Іван", Grade = 85, Course = 1 },
                new Student { Name = "Марія", Grade = 92, Course = 2 },
                new Student { Name = "Петро", Grade = 88, Course = 2 },
                new Student { Name = "Анна", Grade = 91, Course = 3 },
                new Student { Name = "Дмитро", Grade = 72, Course = 3 }
            };

            var filteredStudents = students.Where(s => s.Grade >= 90).ToList();
            Console.WriteLine("Студенти з оцінкою більше або рівною 90:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} - Оцінка: {student.Grade}");
            }

            var sortedStudents = students.OrderByDescending(s => s.Grade).ToList();
            Console.WriteLine("\nСтуденти, відсортовані за оцінкою в спадаючому порядку:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name} - Оцінка: {student.Grade}");
            }

            var groupedStudents = students.GroupBy(s => s.Course).ToList();
            Console.WriteLine("\nГрупування студентів за курсами:");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Курс {group.Key}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Name} - Оцінка: {student.Grade}");
                }
            }

            var studentCounts = students
                .GroupBy(s => s.Course)
                .Select(g => new { Course = g.Key, Count = g.Count() })
                .ToList();
            Console.WriteLine("\nКількість студентів на кожному курсі:");
            foreach (var group in studentCounts)
            {
                Console.WriteLine($"Курс {group.Course}: {group.Count} студентів");
            }

            var projectedStudents = students.Select(s => $"Ім'я: {s.Name}, Оцінка: {s.Grade}").ToList();
            Console.WriteLine("\nСписок студентів з іменами та оцінками:");
            foreach (var student in projectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }

        public static void GetFilteredNumbers(IEnumerable<int> numbers)
        {
            var filteredNumbers = numbers.Where(x => x > 10).ToList();

            Console.Write("Відфільтровані значення: { ");
            filteredNumbers.ForEach(x => Console.Write($"{x} "));
            Console.Write("}");
            Console.WriteLine();
        }

        public static void GetSortedFruits(IEnumerable<string> fruits)
        {
            var sortedFruits = fruits.OrderBy(x => x).ToList();

            Console.Write("Вісортовані значення: { ");
            sortedFruits.ForEach(x => Console.Write($"{x} "));
            Console.Write("}");
            Console.WriteLine();
        }

        public static void GetUniqueStrings(IEnumerable<string> strings)
        {
            var uniqueStrings = strings.Distinct().ToList();

            Console.Write("Унікальні значення: { ");
            uniqueStrings.ForEach(x => Console.Write($"{x} "));
            Console.Write("}");
            Console.WriteLine();
        }

        public static void GetCountOfStudents(IEnumerable<int> grades)
        {
            int count = grades.Count(x => x > 90);

            Console.WriteLine($"Кількість студентів, які отримали більше 90 балів: {count}");
        }

        public static void GetFilteredAndSortedProducts(IEnumerable<Product> products)
        {
            var filteredAndSortedProducts = products
                .Where(p => p.Price < 50)
                .OrderBy(p => p.Price)
                .ToList();

            Console.WriteLine("Відфільтровані та відсортовані значення:");
            filteredAndSortedProducts.ForEach(x => Console.WriteLine($"Назва: {x.Name}, Ціна: {x.Price}"));
        }

        public static void GetMaxIndexAndMaxValue(IEnumerable<int> numbers)
        {
            int maxNumber = numbers.Max();
            int maxIndex = numbers.ToList().IndexOf(maxNumber);

            Console.WriteLine($"Максимальне число: {maxNumber}, на індексі: {maxIndex}");
        }
    }
}