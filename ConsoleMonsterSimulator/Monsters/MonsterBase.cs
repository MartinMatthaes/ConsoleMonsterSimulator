using System;

namespace ConsoleMonsterSimulator.Monsters
{
    abstract class MonsterBase
    {
        public string? Name { get; set; }

        public string? MonsterType { get; set; }

        public int CurrentHP { get; set; }

        public int MaxHP { get; set; }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int AttackSpeed { get; set; }
    }
}
