using System;
using System.Linq;

namespace Kata.Coins.Logic
{
    public class CoinValueCollection
    {
        public readonly CoinValueCollection EuroCoins = new CoinValueCollection("Euro", new int[]{200, 100, 50, 20, 10, 5, 2, 1});
        public readonly CoinValueCollection DollarCoins = new CoinValueCollection("Dollar", new int[]{200, 100, 50, 25, 10, 5, 1});

        private string Name;

        private int[] Values; 

        private CoinValueCollection(String name, int[] values)
        {
            this.Name = name;
            this.Values = values;
        }

        public int[] ToArray()
        {
            int[] copy = new int[this.Values.Length];
            this.Values.CopyTo(copy, 0);
            return copy;
        }

        public override String ToString()
        {
            return $"CoinValueCollection {this.Name} ({String.Join(",", this.Values.Cast<String>())}";
        }
    }
}