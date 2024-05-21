namespace Lesson_13.Models
{
    public abstract class BankAccount
    {
        public Guid AccountNumber { get; set; }
        public string? AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
            AccountNumber = Guid.NewGuid();
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void DisplayAccountInfo();
    }
}
