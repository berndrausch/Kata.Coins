namespace Kata.Coins.Logic
{
    public class CoinValue
    {
        public readonly int Amount;
        public readonly string DisplayText;

        public CoinValue(int amount, string displayText)
        {
            this.Amount = amount;
            this.DisplayText = displayText;
        }

        public override string ToString()
        {
            return this.DisplayText;
        }
    }
}