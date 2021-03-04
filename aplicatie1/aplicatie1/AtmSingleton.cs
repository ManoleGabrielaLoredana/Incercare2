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
}
