using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aplicatie1
{
   
   public class ATM
    {
        private static ATM _instance;
        private Card _card;
        private Account _account;
        private ATM()
        {
            System.Console.WriteLine("New Instance of ATM");
        }
        public static ATM Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ATM();
                }
                return _instance;
            }
        }
        public void Insert(Card card) {
            _card = card;

        }
        public void SelectAccount(Account account)
        {
            var acc = _card.Accounts.Single(a => a == account);
            _account = acc;
        }
        public void Withdraw(decimal amount)
        {
            _account.Withdraw(amount);
            System.Console.WriteLine($"Amount {amount} was withdrawn from the account");
            System.Console.WriteLine($"REAMEANING: {_account.Balance}");
        }
        public void Eject(Card card) 
        { 
        
        }

    }
}
