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

        public void DoFight(Monster player, Monster monster)
        {
            //If player has more AttackSpeed, DoDamage first.
            if (player.S >= monster.S)
            {
                do
                {
                    totalAttacks++;
                    if (player.Health <= 0)
                    {
                        someoneDead = true;
                        Console.Clear();
                        Console.WriteLine($"{player.name} died and {monster.name} won with {monster.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    }
                    player.DoDamage(monster);
                    if (someoneDead) return;

                    if (monster.Health <= 0)
                    {
                        someoneDead = true;
                        Console.Clear();
                        Console.Write($"{monster.name} died and {player.name} won with {player.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    }
                    monster.DoDamage(player);
                }
                while (!someoneDead);
            }
            //If monster has more AttackSpeed, DoDamage first.
            if (player.S < monster.S)
            {
                do
                {
                    totalAttacks++;
                    if (monster.Health <= 0)
                    {
                        someoneDead = true;
                        Console.Clear();
                        Console.Write($"{monster.name} died and {player.name} won with {player.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    }
                    monster.DoDamage(player);
                    if (someoneDead) return;

                    if (player.Health <= 0)
                    {
                        someoneDead = true;
                        Console.Clear();
                        Console.WriteLine($"{player.name} died and {monster.name} won with {monster.Health}HP left.\n\nTotal fights: {totalAttacks}.");
                    }
                    player.DoDamage(monster);
                }
                while (!someoneDead);
            }
        }
    }
}
