using System;
namespace PackagingIndustry
{
    public class TwoDayPackage : Package
    {
        public int bal;
        public int TwoDayPack{get; set;}
        public TwoDayPackage(string senderAddress, string receiverAddress, int twoDayPack) : base(senderAddress, receiverAddress)
        {
            TwoDayPack = twoDayPack;
        }

        public override void CalculateCost()
        {
            bal = TwoDayPack;
            Console.WriteLine($"======={SenderAddress}=======\n======={ReceiverAddress}=======\nThe cost for two days package is {TwoDayPack:C}");
        }
    }
}