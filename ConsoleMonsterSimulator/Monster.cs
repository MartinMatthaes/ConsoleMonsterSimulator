using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    // Monster class with properties like HP, AP, DP, S and a DoDamage() function;
    public partial class Monster 
    {
        public string name = "";

        // HEALTH POINTS
        public float Health { get; set; }

        // ATTACK POINTS
        public float AP { get; set; }

        // DEFENSE POINTS
        public float DP { get; set; }

        // ATTACK SPEED
        public float S { get; set; }


        //Constructor
        public Monster(float health, float aP, float dP, float s)
        {
            Health = health;
            AP = aP;
            DP = dP;
            S = s;
        }

        //Attack method
        public void DoDamage(Monster enemy)
        {
            enemy.Health -= this.AP - enemy.DP;
        }
    }
}
