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
}
