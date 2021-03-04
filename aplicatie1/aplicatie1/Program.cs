using System;

namespace aplicatie1
{
    public abstract class Account
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            var fee = CalculateWithDrawFee(amount);
            amount += fee;
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }
            this.Balance -= amount;
            return amount;
        }
        protected abstract decimal CalculateWithDrawFee(decimal amount);
    }
    public class DebitAccount : Account
    {
        protected override decimal CalculateWithDrawFee(decimal amount)
        {
            return 0m;
        }
    }
    public class SavingAccount : Account
    {
        protected override decimal CalculateWithDrawFee(decimal amount)
        {
            return amount * 0.5m / 100m;
        }
    }
    class Program
    {
        private const int Amount = 500;
        static void Main(string[] args)
        {
            var account = new SavingAccount();
            account.Deposit(200);
            System.Console.WriteLine($"Disponibil: {account.Balance} RON");
            try
            {
                account.Withdraw(100);
            }
            catch(InvalidOperationException)
            {
                System.Console.WriteLine("Fonduri insuficiente");
            }
            System.Console.WriteLine($"Disponibil: {account.Balance} RON");
        }
    }
}
