using System;

namespace BankAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount currentaccount = new CurrentAccount("James", "Stuart", 92934123, "Current", 20000);
            SavingsAccount savingsaccount = new SavingsAccount("Caleb", "Okogbe", 08115432, "Savings", 700000, 1);

            Account[] account = new Account[2] {currentaccount, savingsaccount};

            Console.Write("Enter your account type: ");
            string accountType = Console.ReadLine();

            foreach(var item in account)
            {
                if(accountType == "Current")
                {
                    Console.Write("Write 1 for withdrawal or 2 for deposit: ");
                    int reply = Convert.ToInt32(Console.ReadLine());
                    if( reply == 1)
                    {
                        account[0].Debit();
                        break;
                    }
                    if(reply == 2)
                    {
                        account[0].Credit();
                        break;
                    }else Console.WriteLine("Invalid input");
                    break;
                }

                 if(accountType == "Savings")
                {
                    Console.Write("Write 1 for withdrawal or 2 for deposit: ");
                    int reply = Convert.ToInt32(Console.ReadLine());
                    if( reply == 1)
                    {
                        account[1].Debit();
                        break;
                    }
                    if(reply == 2)
                    {
                        account[1].Credit();
                        break;
                    }else Console.WriteLine("Invalid input");
                    break;
                }

                else Console.Write("invalid input");
                break;
            }

        }
    }
}
