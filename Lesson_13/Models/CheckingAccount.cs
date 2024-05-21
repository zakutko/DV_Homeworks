namespace Lesson_13.Models
{
    public class CheckingAccount : BankAccount
    {
        public double OverdraftLimit { get; set; }

        public CheckingAccount(string accountHolder, double overdraftLimit) : base(accountHolder)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Перевищено ліміт овердрафту.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Номер рахунку: {AccountNumber}");
            Console.WriteLine($"Власник рахунку: {AccountHolder}");
            Console.WriteLine($"Баланс: {Balance:F2}");
            Console.WriteLine($"Ліміт овердрафту: {OverdraftLimit:F2}");
        }
    }
}
