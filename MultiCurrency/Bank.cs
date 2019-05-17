using System.Collections.Generic;

namespace MultiCurrency
{
    public class Bank
    {
        private readonly Dictionary<Pair, int> rates = new Dictionary<Pair, int>();
        public Money Reduce(IExpression source, string to) => source.Reduce(this, to);

        public void AddRate(string from, string to, int rate)
        {
            var key = new Pair(from, to);
            rates.Add(key, rate);
        }

        public int Rate(string from, string to)
        {
            if (from == to) return 1;
            var key = new Pair(from, to);
            return rates[key];
        }
    }
}
