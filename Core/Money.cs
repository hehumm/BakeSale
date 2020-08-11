namespace BakeSale.Core
{
    public class Money
    {
        public float Amount { get; set; }
        public Currency Currency { get; set; }

        public void ChangeAmount(float amount)
        {
            Amount += amount;
        }
    }
}