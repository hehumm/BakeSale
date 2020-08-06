namespace BakeSale.Core
{
    public class Money
    {
        public float Amount { get; private set; }
        public Currency Currency { get; }

        public void ChangeMoneyAmount(float amount)
        {
            Amount += amount;
        }
    }
}