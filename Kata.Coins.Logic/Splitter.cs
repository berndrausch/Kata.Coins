
namespace Kata.Coins.Logic;
{
    public class Splitter
    {
        private ISplitupStrategy Strategy;

        public Splitter(ISplitupStrategy strategy)
        {
            this.Strategy = strategy;
        }
    }
}