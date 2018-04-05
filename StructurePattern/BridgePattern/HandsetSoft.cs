using System;

namespace BridgePattern
{
    internal abstract class HandsetSoft
    {
        public abstract void Run();
    }

    internal class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("Game is running...");
        }
    }

    internal class HandsetMp3 : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("Mp3 is running...");
        }
    }

    internal class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("AddressList is running...");
        }
    }
}
