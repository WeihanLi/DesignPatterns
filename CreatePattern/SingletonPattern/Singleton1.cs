namespace SingletonPattern
{
    public sealed class Singleton1
    {
        private static readonly Singleton1 Instance = new Singleton1();

        private Singleton1()
        {
        }

        public static Singleton1 GetInstance() => Instance;
    }
}
