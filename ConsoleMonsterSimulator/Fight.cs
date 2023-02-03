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
        public int totalAttacks = 0;

        // Fight logic
        public void DoFight(Monster player, Monster monster)
        {
            // Monster with higher attack-speed "S" executes first attack
            if (player.S >= monster.S)
            {
                monster.Health -= player.AP - monster.DP;
            }
            if (player.S < monster.S)
            {
                player.Health -= monster.AP - monster.DP;
            }
    
            // Do while loop as long as nobody is dead yet
            while (!someoneDead)
            {
                // count totalAttacks + 1 for every round fought
                totalAttacks++;
                // If player dies first
                if (player.Health <= 0)
                {
                    someoneDead = true;
                    Console.Clear();
                    Console.WriteLine($"{player.name} died and {monster.name} won with {monster.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    break;
                }
                // Player does damage if still alive
                player.DoDamage(monster);
                // If monster dies first
                if (monster.Health <= 0)
                {
                    someoneDead = true;
                    Console.Clear();
                    Console.WriteLine($"{monster.name} died and {player.name} won with {player.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    break;
                }
                // Monster does damage if still alive
                monster.DoDamage(player);
                //player.Health -= monster.AP - player.DP;

                // Update user in real-time on monster healths
                Console.Clear();
                Console.WriteLine($"{player.name} health: {player.Health}\n{monster.name} health: {monster.Health}");
                // Pause for a short time so that it is readable
                Thread.Sleep(20);
            }
        }
    }
}
