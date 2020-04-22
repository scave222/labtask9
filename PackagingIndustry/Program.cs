using System;

namespace PackagingIndustry
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDayPackage twodaypack = new TwoDayPackage("Nigeria", "USA", 3000);
            OvernightPackage overnightpack = new OvernightPackage("Ghana", "Canada", 4500);

            Package[] pack = new Package[2] {twodaypack, overnightpack};

            foreach(var item in pack)
            {
                item.CalculateCost();
            }
        }
    }
}
