namespace MultiCurrency
{
    public abstract class Money
    {
        public static Dollar Dollar(int amount) => new Dollar(amount, "USD");
        public static Franc Franc(int amount) => new Franc(amount, "CHF");

        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public string Currency => currency;

        public abstract Money Times(int amount);

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
    }
}
