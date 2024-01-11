using System.Transactions;

namespace BankingTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GenerateRandomTransactions_ShouldReturnCorrectNumberOfTransactions()
        {
            string accountNumber = "123456";
            int transactionCount = 10;
            double startingBalance = 1000.0;

            var transactions = Transaction.GenerateRandomTransactions(accountNumber, transactionCount, startingBalance);

            Assert.AreEqual(transactionCount, transactions.Count, "The number of generated transactions should match the requested count.");
        }
















    }
}