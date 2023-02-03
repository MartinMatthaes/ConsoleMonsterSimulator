namespace ConsoleMonsters.Monsters
{
    // Monster class with monster name
    public class Ghoul : Monster
    {
        public Ghoul(float health, float aP, float dP, float s) : base(health, aP, dP, s)
        {
            name = "Ghoul";
        }
    }
}
