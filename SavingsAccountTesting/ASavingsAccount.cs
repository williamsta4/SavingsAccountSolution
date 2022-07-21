using SavingsAccountLib;
namespace SavingsAccountTesting
{
    [TestClass]
    public class ASavingsAccount
    {

        [TestMethod]
        public void HasAnAccountNumber()
        {
            var sut = new SavingsAccount { AccountNumber = "A1234" };
            Assert.AreEqual("A1234", sut.AccountNumber);
        }


        [TestMethod]

        public void AllowsWithdrawals()
        {
            var sut = new SavingsAccount { Balance = 100 };
            sut.WithdrawMoney(50);
            Assert.AreEqual(50, sut.Balance);
         }

        [TestMethod]
        public void AllowsDeposits()
        {
            var sut = new SavingsAccount { Balance = 100 };
            sut.DepositMoney(50);
            Assert.AreEqual(150, sut.Balance);
        }

        [TestMethod]
        public void CanEarnInterest()
        {
            var sut = new SavingsAccount { Balance = 100, AnnualInterestRate = .1m };
            Assert.AreEqual(.83m, sut.InterestEarned);
        }


        [TestMethod]
        public void CanUpdateBalanceWithInterestEarned()
        {
            var sut = new SavingsAccount { Balance = 100, AnnualInterestRate = .1m };
            sut.UpdateBalanceWithInterestEarned();
            Assert.AreEqual(100.83m, sut.Balance);
        }
    }
}