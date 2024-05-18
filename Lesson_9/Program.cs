using Lesson_9.Models;

namespace Lesson_9
{
    public static class Program
    {
        public static void Main()
        {
            var book1 = new Book("Книга1", "Автор1", DateTime.Now, 565);
            book1.DisplayInfo();
            Console.WriteLine(book1.IsThick());

            var book2 = new Book("Книга2", "Автор2", DateTime.Now, 123);
            book2.DisplayInfo();
            Console.WriteLine(book2.IsThick());

            Console.ReadKey();
        }
    }
}