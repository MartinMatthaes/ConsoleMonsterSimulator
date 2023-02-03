namespace ConsoleMonsters.Monsters
{
    // Monster class with monster name
    public class Shapeshifter : Monster
    {
        public Shapeshifter(float health, float aP, float dP, float s, float maxHealth) : base(health, aP, dP, s, maxHealth)
        {
            name = "Shapeshifter";
        }
    }
}
