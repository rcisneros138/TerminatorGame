using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Enemy
    {
        Random rand = new Random();
        public int health;
        public Enemy() //lol
        {
            health = rand.Next(10, 90);
            
        }
        public void strike()
        {
            int strikeDamage = rand.Next(10, 20);
        }
    }
}
