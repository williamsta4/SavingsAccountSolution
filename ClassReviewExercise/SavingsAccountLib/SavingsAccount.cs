namespace SavingsAccountLib
{
    public class SavingsAccount
    {
        public string AccountNumber { get; set; } = string.Empty;

        public decimal Balance { get; set; } = 100;

        public void WithdrawMoney(decimal amount)
        {
            Balance -= amount;
        }

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
        }

        public decimal AnnualInterestRate { get; set; } = 0;

        public decimal InterestEarned
        {
            get 
            {
                decimal monthlyInterestRate = AnnualInterestRate / 12;
                decimal interestEarned = Balance * monthlyInterestRate;
                return  Math.Round(interestEarned,2); 
               
            }
        }


        public void UpdateBalanceWithInterestEarned()
        {
            Balance += InterestEarned; 
        }
        

    } 

}

