using System;

namespace BridgePattern
{
    internal abstract class HandsetBrand
    {
        protected HandsetSoft Soft;

        public void SetHandsetSoft(HandsetSoft soft)
        {
            Soft = soft;
        }

        public abstract void Run();
    }

    internal class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            Soft.Run();
            Console.WriteLine("running in brand M");
        }
    }

    internal class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            Soft.Run();
            Console.WriteLine("running in brand N");
        }
    }
}
