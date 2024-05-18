namespace Lesson_10.Models
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person(string name) : this(name, 0, "не вказано") { }
        public Person(string name, int age) : this(name, age, "не вказано") { }

        public void PrintDetails()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Стать: {Gender}");
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
