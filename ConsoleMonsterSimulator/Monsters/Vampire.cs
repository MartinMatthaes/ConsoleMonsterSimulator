namespace ConsoleMonsters.Monsters
{
    // Monster class with monster name
    public class Vampire : Monster
    {
        public Vampire(float health, float aP, float dP, float s, string name) : base(health, aP, dP, s)
        {
            this.name = name;
        }
    }
}
