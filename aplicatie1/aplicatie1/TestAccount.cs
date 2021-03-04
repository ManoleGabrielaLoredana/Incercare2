namespace aplicatie1
{
    class TestAccount : IAccount
    {
      //  public decimal Balance => throw new System.NotImplementedException();
      public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
          //  throw new System.NotImplementedException();
        }

        public decimal Withdraw(decimal amount)
        {
            // throw new System.NotImplementedException();
            return 0m;
        }
    }
}