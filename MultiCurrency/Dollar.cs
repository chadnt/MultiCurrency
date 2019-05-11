namespace MultiCurrency
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier) => new Dollar(amount * multiplier);
    }
}
