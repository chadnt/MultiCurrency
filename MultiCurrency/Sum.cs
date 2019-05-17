using System;

namespace MultiCurrency
{
    public class Sum : IExpression
    {
        private readonly IExpression augend;
        private readonly IExpression addend;

        public Sum(IExpression augend, IExpression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public IExpression Plus(IExpression addend) => new Sum(this, addend);

        public Money Reduce(Bank bank, string to)
        {
            var amount = augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }
    }
}
