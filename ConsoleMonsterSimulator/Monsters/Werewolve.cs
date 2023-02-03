namespace ConsoleMonsters.Monsters
{
    // Monster class with monster name
    public class Werewolve : Monster
    {
        public Werewolve(float health, float aP, float dP, float s, float maxHealth) : base(health, aP, dP, s, maxHealth)
        {
            name = "Werewolve";
        }
    }
}
