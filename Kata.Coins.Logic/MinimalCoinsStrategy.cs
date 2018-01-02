namespace Kata.Coins.Logic
{
    public class MinimalCoinsStrategy : ISplitupStrategy
    {
        public int[] Splitup(int amount, int[] coinValues)
        {
            int[] result = new int[coinValues.Length];
            int tempAmount = amount;

            for (int i=0; i < coinValues.Length; i++)
            {
                result[i] = tempAmount / coinValues[i];
                tempAmount = tempAmount % coinValues[i];
            }

            return result;
        }
    }
}