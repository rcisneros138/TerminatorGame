using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class ChooseWeapon
    {
        public ChooseWeapon()
        {
            Console.WriteLine("choose a weapon: 1 - shotgun, 2 - gatlin gun 3  - grenade Launcher");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("you chose a Shotgun!");
                    playGameAsStandard(1);
                    break;
                case 2:
                    Console.WriteLine("you chose a Gatlin Gun");
                    playGameAsStandard(2);
                    break;
                case 3:
                    Console.WriteLine("you chose a GRENADE LAUNCHER");
                    playGameAsStandard(3);
                    break;
            }
        }
        public void playGameAsStandard(int wepChoice)
        {
            StandardModelTerminator terminator = new StandardModelTerminator();
            Enemy enemy = new Enemy();
            Console.WriteLine("An enemy has appeared with {0} health", enemy.health);
            while (terminator.health>0)
            {
                Console.WriteLine("make a move! 1 to shoot, 2 to walk closer");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    
                    int enemyHealth = enemy.health -= terminator.shoot(wepChoice);
                    Console.WriteLine("Enemy took {0} damage and now has {1} health",terminator.shoot(wepChoice), enemyHealth);
                    
                }
                else
                {
                    terminator.walk();
                }
            }
        }
    }
}