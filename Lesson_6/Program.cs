namespace Lesson_6
{
    public class Program
    {
        public static void Main()
        {
            ProcessFirstTask();
            Console.WriteLine();
            ProcessSecondTask();
            Console.WriteLine();
            ProcessThirdTask();
            Console.WriteLine();
            ProcessFourthTask();

            Console.ReadKey();
        }

        public static void ProcessFirstTask()
        {
            int[] array = new int[10];
            Random random = new Random();

            int positiveCount = 0;
            Console.Write("Масив: {");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                if (array[i] > 0)
                {
                    positiveCount++;
                }

                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("}");
            Console.WriteLine($"Кількість додатних чисел у масиві: {positiveCount}");
        }

        public static void ProcessSecondTask()
        {
            int[] array = { 5, -9, 8, 7 };

            Console.Write("Масив: {");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.Write("Інверсія: {");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }

        public static void ProcessThirdTask()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            int elementToAdd = random.Next(-100, 101);

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            AddElementToBeginning(ref array, elementToAdd);

            Console.WriteLine("Масив після додавання елемента на початок:");
            PrintArray(array);
        }

        public static void AddElementToBeginning(ref int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = element;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }

        public static void ProcessFourthTask()
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 6);
            }

            Console.WriteLine("Елементи масиву до першого входження -1:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == -1)
                {
                    break;
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}