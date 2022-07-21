//START OF APP
using SavingsAccountLib;

//Annual Interest Rate
Console.Write("Please input the Annual Interest Rate: ");
string? air = Console.ReadLine(); //inputs the annual interest rate as a string
Decimal.TryParse(air, out decimal annualInterestRate);//parses to a decimal 
//-----

//Starting Balance
Console.Write("Please input the  starting balance: ");
string? sb = Console.ReadLine(); //inputs the starting balance as a string named sb
Decimal.TryParse(sb, out decimal startingBalance);//parses to a decimal 
//-----

//Number of Months
Console.Write("Please input the number of months: ");
string? nom = Console.ReadLine(); //inputs the number of months as a string called nom 
Decimal.TryParse(nom, out decimal numberOfMonths);//parses to a decimal 
//-----

//creates a new instance of SavingsAccount
var account = new SavingsAccount() { Balance = startingBalance, AnnualInterestRate = annualInterestRate};
decimal Balance = 0;
Balance += startingBalance;
//-----

//variables
decimal totalDeposits = 0;
decimal totalWithdrawals = 0;
decimal totalInterestEarned = 0;
//-----

//Start of For 
for (int i = 1; i < numberOfMonths + 1; i++)
{
    //Amount Deposited 
    Console.Write("Please input the amount depostied: ");
    string? ad = Console.ReadLine(); //inputs the starting balance as a string named ad
    Decimal.TryParse(ad, out decimal amountDeposited);//parses to a decimal 
    totalDeposits += amountDeposited;
    account.DepositMoney(amountDeposited);
    //-----

    //Amount Withdrawn
    Console.Write("Please input the amount withdrawn: ");
    string? aw = Console.ReadLine(); //inputs the starting balance as a string named aw
    Decimal.TryParse(aw, out decimal amountWithdrawn);//parses to a decimal 
    totalWithdrawals += amountWithdrawn;
    account.WithdrawMoney(amountWithdrawn);
    //-----



    //MATH for Total Balance
    totalInterestEarned += account.InterestEarned;
    account.UpdateBalanceWithInterestEarned();
    //-----
    

}
//END of For


//OUTPUT
Console.WriteLine("Your ending Balance is: " + account.Balance);
Console.WriteLine("Your total deposits are: " + totalDeposits);
Console.WriteLine("Your total withdrawals are: " + totalWithdrawals);
Console.WriteLine("Your total interest earned is: " + totalInterestEarned);
//END of APP