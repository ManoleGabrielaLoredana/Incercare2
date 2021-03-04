namespace aplicatie1
{
    public interface IAccount
    {
        decimal Balance { get; }

        void Deposit(decimal amount);
        decimal Withdraw(decimal amount);
    }
}