namespace PackagingIndustry
{
    abstract public class Package
    {
        public string SenderAddress {get; set;}
        public string ReceiverAddress {get; set;}

        public Package(string senderAddress, string receiverAddress)
        {
            SenderAddress = senderAddress;
            ReceiverAddress = receiverAddress;
        }

        abstract public void CalculateCost();
    }
}