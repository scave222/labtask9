using System;
namespace BankAPP
{
    abstract public class Account
    {
         public string FistName {get; set;}
         public string LastName {get; set;}
         public int AccountNumber {get; set;}
         public string AccountType {get; set;}
         public decimal Balance {get; set;}

         public Account(string firstName, string lastName, int accountNumber, string accountType, decimal balance)
         {
             FistName = firstName;
             LastName = lastName;
             AccountNumber = accountNumber;
             AccountType = accountType;
             Balance = balance;
         }

         abstract public void AccountBalance();

         public virtual void Debit()
         {

            Console.Write("Enter the amount you want to withdraw: ");
            decimal amountWithdraw = Convert.ToDecimal(Console.ReadLine());
            if(Balance >= amountWithdraw)
            {
                Balance -= amountWithdraw;
                AccountBalance();
                
            } else {
                throw new ArgumentOutOfRangeException("You have insufficient balance");
            }
         }

         public virtual void Credit()
         {

            Console.Write("Enter the amount you want to deposit: ");
            decimal amountDeposit = Convert.ToDecimal(Console.ReadLine());
                Balance +=amountDeposit;
                AccountBalance();
            
         }
    }
}