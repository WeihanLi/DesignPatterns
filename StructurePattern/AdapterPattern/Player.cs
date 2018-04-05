using System;

namespace AdapterPattern
{
    internal abstract class Player
    {
        public abstract void Attact();

        public abstract void Defend();
    }

    internal class Forwards : Player
    {
        private readonly string _name;

        public Forwards(string name) => _name = name;

        public override void Attact()
        {
            Console.WriteLine($"前锋 {_name} attact");
        }

        public override void Defend()
        {
            Console.WriteLine($"前锋 {_name} defend");
        }
    }

    internal class Guards : Player
    {
        private readonly string _name;

        public Guards(string name) => _name = name;

        public override void Attact()
        {
            Console.WriteLine($"后卫 {_name} attact");
        }

        public override void Defend()
        {
            Console.WriteLine($"后卫 {_name} defend");
        }
    }

    internal class ForeignGuards
    {
        private readonly string _name;

        public ForeignGuards(string name) => _name = name;

        public void 进攻()
        {
            Console.WriteLine($"后卫 {_name} 进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"后卫 {_name} 防守");
        }
    }

    internal class Translator : Player
    {
        private readonly ForeignGuards _foreignGuards;

        public Translator(string name) => _foreignGuards = new ForeignGuards(name);

        public override void Attact() => _foreignGuards.进攻();

        public override void Defend() => _foreignGuards.防守();
    }
}
