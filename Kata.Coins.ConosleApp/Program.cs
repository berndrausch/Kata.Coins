using System;
using Kata.Coins.Logic;

namespace Kata.Coins.ConosleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Splitter splitter = new Splitter(new MinimalCoinsStrategy());
            CoinValueCollection currency = CoinValueCollection.EuroCoins;
            CoinValue[] coinValues = currency.ToArray();

            Console.WriteLine("Total amount of money?");
            String input = Console.ReadLine();
            if ( !int.TryParse(input, out int amount))
            {
                Console.WriteLine($"Could not parse input [{input}]");
            }
            else
            {
                int[] result = splitter.Splitup(amount, currency);
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"{coinValues[i]}:\t{result[i]}");
                }
            }
        }
    }
}
