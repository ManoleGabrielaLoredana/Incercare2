using System;

namespace aplicatie1
{
    public class AtmSingleton
    {
        private readonly DebitAccount _debitAccount;
        private static readonly AtmSingleton _instance = new AtmSingleton();
        private AtmSingleton()
        {
            _debitAccount = new DebitAccount();
        }
        public static AtmSingleton TheATM => _instance;
        public DebitAccount DebitAccount => _debitAccount;
    }
    class Program
    {
        private const int Amount = 500;
        static void Main(string[] args)
        {
            AtmSingleton.TheATM.DebitAccount.Deposit(100);
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
