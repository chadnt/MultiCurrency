namespace MultiCurrency
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   amount == money.amount;
        }

        public override int GetHashCode()
        {
            return -1658239311 + amount.GetHashCode();
        }
    }
}
