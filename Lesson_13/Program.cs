using Lesson_13.Models;

namespace Lesson_13
{
    public class Program
    {
        public static void Main()
        {
            // Створення екземплярів класів
            var savingsAccount = new SavingsAccount("John Doe", 0.05); // 5% річний відсоток
            var checkingAccount = new CheckingAccount("Jane Doe", 500); // ліміт овердрафту 500

            // Тестування SavingsAccount
            Console.WriteLine("=== Savings Account ===");
            savingsAccount.Deposit(1000);
            savingsAccount.DisplayAccountInfo();
            savingsAccount.Withdraw(200);
            savingsAccount.DisplayAccountInfo();

            // Тестування CheckingAccount
            Console.WriteLine("=== Checking Account ===");
            checkingAccount.Deposit(1000);
            checkingAccount.DisplayAccountInfo();
            checkingAccount.Withdraw(1200);
            checkingAccount.DisplayAccountInfo();
            checkingAccount.Withdraw(400);
            checkingAccount.DisplayAccountInfo();
        }
    }
}