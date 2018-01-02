namespace Kata.Coins.Logic
{
    ///<summary>
    /// Strategy for splitting up an amount of money into several coins.
    ///</summary>
    public interface ISplitupStrategy
    {
        ///<summary>
        /// Split up an amount of money into several coins according to the given
        /// available coin values.
        ///</summary>
        ///<param name="amount">Amount of money to split up in the smallest unit.</param> 
        ///<param name="coinValues">Available coin values from largest to smallest value.</param> 
        int[] Splitup(int amount, int[] coinValues);
    }
}