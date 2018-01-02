using System.Linq;


namespace Kata.Coins.Logic
{
    public class Splitter
    {
        private ISplitupStrategy Strategy;

        public Splitter(ISplitupStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public int[] Splitup(int amount, CoinValueCollection coinValues)
        {
            return this.Strategy.Splitup(amount, coinValues.ToArray().Select( c => c.Amount).ToArray());
        }
    }
}