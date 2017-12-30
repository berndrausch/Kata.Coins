namespace Kata.Coins.Logic
{
    public interface ISplitupStrategy
    {
        int[] Splitup(int amount, int[] coinValues);
    }
}