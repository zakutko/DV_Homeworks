
namespace Lesson_9.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, DateTime releaseYear, int numberOfPages)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
            NumberOfPages = numberOfPages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"Назва книги: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Рік видання: {ReleaseYear.Year}");
            Console.WriteLine($"Кількість сторінок: {NumberOfPages}");
            Console.WriteLine("***********************");
        }

        public string IsThick()
        {
            return NumberOfPages > 500 ?$"Ця книга товста! Цілих {NumberOfPages} сторінок!" : $"Ця книга не твоста. Усього {NumberOfPages} сторінок.";
        }
    }
}
