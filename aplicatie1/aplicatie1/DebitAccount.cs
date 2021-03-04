namespace aplicatie1
{
    public class DebitAccount : Account
    {
        protected override decimal CalculateWithDrawFee(decimal amount)
        {
            return 0m;
        }
    }
}
