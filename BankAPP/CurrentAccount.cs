using System;
namespace BankAPP
{
    public class CurrentAccount : Account
    {
        public CurrentAccount (string firstName, string lastName, int accountNumber, string accountType, decimal accountBalance) : base(firstName, lastName, accountNumber, accountType, accountBalance)
        {

        }

        public override void AccountBalance()
        {
            Console.WriteLine($"Your account balance is now {Balance:C}. Thank you for banking with us");
        //    return Convert.ToDecimal(Debit());
        }
    }
}