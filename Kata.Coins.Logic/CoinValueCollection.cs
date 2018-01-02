using System;
using System.Linq;

namespace Kata.Coins.Logic
{
    public class CoinValueCollection
    {
        public static readonly CoinValueCollection EuroCoins = new CoinValueCollection("Euro", new CoinValue[]
        {
            new CoinValue(200, "2€"),
            new CoinValue(100, "1€"),
            new CoinValue(50, "50c"),
            new CoinValue(20, "20c"),
            new CoinValue(10, "10c"),
            new CoinValue(5, "5c"),
            new CoinValue(2, "2c"),
            new CoinValue(1, "1c"),
        });
        public static readonly CoinValueCollection DollarCoins = new CoinValueCollection("Dollar", new CoinValue[]       
        {
            new CoinValue(200, "2$"),
            new CoinValue(100, "1$"),
            new CoinValue(50, "50c"),
            new CoinValue(25, "25c"),
            new CoinValue(10, "10c"),
            new CoinValue(5, "5c"),
            new CoinValue(1, "1c"),
        });

        private string Name;

        private CoinValue[] Values; 

        private CoinValueCollection(String name, CoinValue[] values)
        {
            this.Name = name;
            this.Values = values;
        }

        public CoinValue[] ToArray()
        {
            CoinValue[] copy = new CoinValue[this.Values.Length];
            this.Values.CopyTo(copy, 0);
            return copy;
        }

        public override String ToString()
        {
            return $"CoinValueCollection {this.Name} ({String.Join(",", this.Values.Cast<String>())}";
        }
    }
}