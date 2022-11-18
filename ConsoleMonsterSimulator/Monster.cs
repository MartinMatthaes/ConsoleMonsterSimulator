using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    public partial class Monster 
    {
        public string name = "";

        public float Health { get; set; }

        // ATTACK POINTS
        public float AP { get; set; }

        // DEFENSE POINTS
        public float DP { get; set; }

        // ATTACK SPEED
        public float S { get; set; }

        protected float maxHealth { get; set; }

        public Monster(float health, float aP, float dP, float s, float maxHealth)
        {
            Health = health;
            AP = aP;
            DP = dP;
            S = s;
            this.maxHealth = health;
        }

        public void DoDamage(Monster enemy)
        {
            enemy.Health -= this.AP - enemy.DP;
        }
    }
}
