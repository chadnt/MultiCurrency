namespace MultiCurrency
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   amount == money.amount
                   && GetType() == money.GetType();
        }

        public override int GetHashCode()
        {
            return -1658239311 + amount.GetHashCode();
        }

        public static Dollar Dollar(int amount) => new Dollar(amount);
        public static Franc Franc(int amount) => new Franc(amount);

        public abstract Money Times(int amount);
    }
}
