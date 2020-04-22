using System;
namespace BankAPP
{
    public class SavingsAccount : Account
    {
        public decimal interest;
        public double InterestRate{get; set;}
        public SavingsAccount (string firstName, string lastName, int accountNumber, string accountType, decimal accountBalance, double interestRate) : base(firstName, lastName, accountNumber, accountType, accountBalance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            interest = ((decimal)InterestRate * Balance) / 100;
        }

         public override void Credit()
         {

            Console.Write("Enter the amount you want to deposit: ");
            decimal amountDeposit = Convert.ToDecimal(Console.ReadLine());
            CalculateInterest();
                Balance = Balance + interest + amountDeposit;
                AccountBalance();
            
         }

          public override void Debit()
         {

            Console.Write("Enter the amount you want to withdraw: ");
            decimal amountWithdraw = Convert.ToDecimal(Console.ReadLine());
            if(Balance >= amountWithdraw)
            {
                CalculateInterest();
                Balance = Balance - amountWithdraw + interest;
                AccountBalance();
                
            } else {
                throw new ArgumentOutOfRangeException("You have insufficient balance");
            }
         }

          public override void AccountBalance()
        {
            Console.WriteLine($"Your account balance is now {Balance:C}. Thank you for banking with us");
        
        }
    }
}