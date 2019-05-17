using System.Collections.Generic;

namespace MultiCurrency
{
    class Pair
    {
        private readonly string from;
        private readonly string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            var pair = obj as Pair;
            return pair != null &&
                   from == pair.from &&
                   to == pair.to;
        }

        public override int GetHashCode()
        {
            var hashCode = -1951484959;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(from);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(to);
            return hashCode;
        }
    }
}
