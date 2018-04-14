using System;

namespace MementoPattern
{
    internal class GameRole
    {
        public GameRole()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine($"生命力：{Vitality}");
            Console.WriteLine($"攻击力：{Attack}");
            Console.WriteLine($"防御力：{Defense}");
            Console.WriteLine();
        }

        public void FightWithBoss()
        {
            Vitality = 1;
            Attack = 10;
            Defense = 0;
        }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            Vitality = memento.Vitality;
            Attack = memento.Attack;
            Defense = memento.Defense;
        }
    }
}
