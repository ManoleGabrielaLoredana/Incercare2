using System;
using System.Collections.Generic;
using System.Text;

namespace aplicatie1
{
    public class Card
    {
        public Card(string cardHolder)
        {
            Holder = cardHolder;
            Accounts = new List<Account>();
        }
        public string Holder { get; private set; }
        public IEnumerable<Account> Accounts { get; private set; }
        internal void AddAccount(SavingAccount account)
        {
            (Accounts as List<Account>).Add(account);
        }
    }
}
