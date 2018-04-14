namespace MementoPattern
{
    /// <summary>
    /// 游戏角色信息备忘录
    /// </summary>
    internal class RoleStateMemento
    {
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; }
    }
}
