namespace MultiCurrency
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier) => new Franc(amount * multiplier);
    }
}
