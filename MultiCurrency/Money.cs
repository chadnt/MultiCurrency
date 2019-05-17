namespace MultiCurrency
{
    public class Money : IExpression
    {
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public int Amount { get; }

        public string Currency { get; }

        public IExpression Times(int multiplier) => new Money(Amount * multiplier, Currency);

        public IExpression Plus(IExpression addend) => new Sum(this, addend);

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   Amount == money.Amount
                   && Currency == money.Currency;
        }
        public override int GetHashCode()
        {
            return -1658239311 + Amount.GetHashCode();
        }
    }
}
