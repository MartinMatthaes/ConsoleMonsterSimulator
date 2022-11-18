using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    class Fight
    {
        public bool someoneDead = false;
        public int totalAttacks;

        public void DoFight(Monster player, Monster monster)
        {
            if (player.S >= monster.S)
            {
                monster.Health -= player.AP - monster.DP;
            }
            if (player.S < monster.S)
            {
                player.Health -= monster.AP - monster.DP;
            }


            while (!someoneDead)
            {
                totalAttacks++;
                if (player.Health <= 0)
                {
                    someoneDead = true;
                    Console.Clear();
                    Console.WriteLine($"{player.name} died and {monster.name} won with {monster.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                }
                player.DoDamage(monster);
                //monster.Health -= player.AP - monster.DP;
                if (someoneDead) return;
                if (monster.Health <= 0)
                {
                    someoneDead = true;
                    Console.Clear();
                    Console.WriteLine($"{monster.name} died and {player.name} won with {player.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                }
                monster.DoDamage(player);
                //player.Health -= monster.AP - player.DP;
            }
        }
    }
}
