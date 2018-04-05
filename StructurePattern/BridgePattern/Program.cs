using System;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HandsetBrand handsetBrand = new HandsetBrandM();
            handsetBrand.SetHandsetSoft(new HandsetMp3());
            handsetBrand.Run();
            handsetBrand.SetHandsetSoft(new HandsetGame());
            handsetBrand.Run();

            handsetBrand = new HandsetBrandN();
            handsetBrand.SetHandsetSoft(new HandsetAddressList());
            handsetBrand.Run();

            Console.ReadLine();
        }
    }
}
