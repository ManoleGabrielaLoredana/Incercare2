using System;

namespace aplicatie1
{
    class Program
    {
        private const int Amount = 500;
        static void Main(string[] args)
        {
            //AtmSingleton.TheATM.DebitAccount.Deposit(100);
            //var account = new SavingAccount();
            //account.Deposit(200);
            //System.Console.WriteLine($"Disponibil: {account.Balance} RON");
            //try
            //{
            //    account.Withdraw(100);
            //}
            //catch(InvalidOperationException)
            //{
            //    System.Console.WriteLine("Fonduri insuficiente");
            //}
            //System.Console.WriteLine($"Disponibil: {account.Balance} RON");

            //Prepare
            var account = new SavingAccount();
            account.Deposit(200);
            var card = new Card("Andrei Ionut");
            card.AddAccount(account);

            //Withdraw from ATM
            ATM.Instance.Insert(card);
            ATM.Instance.SelectAccount(account);
            ATM.Instance.Withdraw(100);
        }
    }
}
