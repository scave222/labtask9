using System;
namespace PackagingIndustry
{
    public class OvernightPackage : Package
    {
        public int OvernightPack{get; set;}
        public OvernightPackage(string senderAddress, string receiverAddress, int overnightPack) : base(senderAddress, receiverAddress)
        {
            OvernightPack = overnightPack;
            
        }

        public override void CalculateCost()
        {
            Console.WriteLine($"======={SenderAddress}=======\n======={ReceiverAddress}=======\nThe cost for Overnight package is {OvernightPack:C}");
        }
        
    }
}