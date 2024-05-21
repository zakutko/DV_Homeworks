namespace Lesson_13.Models
{
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountHolder, double interestRate) : base(accountHolder)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостатньо коштів для зняття.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Номер рахунку: {AccountNumber}");
            Console.WriteLine($"Власник рахунку: {AccountHolder}");
            Console.WriteLine($"Баланс: {Balance:F2}");
            Console.WriteLine($"Відсоткова ставка: {InterestRate:P}");
        }
    }
}
