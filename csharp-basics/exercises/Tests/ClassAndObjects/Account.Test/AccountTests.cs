using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Account.Test
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CheckWithdraw_NameBartoBalance100Withddrawal20_Expecte80Balance()
        {
            // Arrange
            Account testAccount = new Account("Barto", 100.00);

            // Act
            double result = testAccount.Withdrawal(20);

            // Assert
            Assert.AreEqual(80, result);
        }

        [TestMethod]
        public void CheckDeposit_NameBartoBalance100Deposit20_Expected120Balance()
        {
            // Arrange
            Account testAccount = new Account("Barto", 100.00);

            // Act
            double result = testAccount.Deposit(20);

            // Assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void CheckDeposit_NameBartoBalance100BNameKartoBalance50Transfer40_Expected90Balance()
        {
            // Arrange
            Account testAccount1 = new Account("Barto", 100.00);
            Account testAccount2 = new Account("Karto", 50.00);

            // Act
            Account.Transfer(testAccount1, testAccount2, 40.0);

            // Assert
            Assert.AreEqual(90, testAccount2.Balance());
        }

        [TestMethod]
        public void CheckToString_NameBartoBalance100_ExpectedBalanceBarto100()
        {
            // Arrange
            Account testAccount = new Account("Barto", 100.00);

            // Act
            string result = testAccount.ToString();

            // Assert
            Assert.AreEqual("Barto: 100", result);
        }
    }
}
