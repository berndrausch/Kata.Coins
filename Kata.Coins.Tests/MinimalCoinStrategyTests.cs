using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.Coins.Logic;

namespace Kata.Coins.Tests
{
    [TestClass]
    public class MinimalCoinStrategyTests
    {
        private ISplitupStrategy Sut;

        [TestInitialize]
        public void Init()
        {
            this.Sut = new MinimalCoinsStrategy();
        }

        [TestMethod]
        public void SplitupReturnsCorrectResultForAmountOne()
        {
            int[] actual = this.Sut.Splitup(1, new int[]{1});

            Assert.IsNotNull(actual);
            Assert.AreEqual(1, actual.Length);
            Assert.AreEqual(1, actual[0]);
        }

        [DataTestMethod]
        [DataRow(1, new int[]{1}, new int[]{1})]
        [DataRow(1, new int[]{2,1}, new int[]{0,1})]
        [DataRow(2, new int[]{2,1}, new int[]{1,0})]
        [DataRow(67, new int[]{200, 100, 50, 20, 10, 5, 2, 1}, new int[]{0,0,1,0,1,1,1,0})]
        [DataRow(133, new int[]{200, 100, 50, 20, 10, 5, 2, 1}, new int[]{0,1,0,1,1,0,1,1})]
        [DataRow(751, new int[]{200, 100, 50, 20, 10, 5, 2, 1}, new int[]{3,1,1,0,0,0,0,1})]
        public void SplitupTests(int amount, int[] coins, int[] expected)
        {
            int[] actual = this.Sut.Splitup(amount, coins);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Length, actual.Length);
            for(int i=0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"Coin number {i} with value {coins[i]} for amount {amount} not as expected");
            }
        }
    }
}
