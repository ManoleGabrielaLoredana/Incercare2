namespace aplicatie1
{
    public class SavingAccount : Account
    {
        protected override decimal CalculateWithDrawFee(decimal amount)
        {
            return amount * 0.5m / 100m;
        }
    }
}
