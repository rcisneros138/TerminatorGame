using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class StandardModelTerminator: ITerminator
    {
        
        Shotgun shotgun = new Shotgun();
        grenadeLauncher grenageLaunch = new grenadeLauncher();
        GatlinGun gatlin = new GatlinGun();
        List<object> weapons = new List<object>();
        public int bonusDamage;
        public int health = 100;
        public StandardModelTerminator()
        {
            weapons.Add(gatlin);
            weapons.Add(shotgun);
            weapons.Add(grenageLaunch);
            
        }
       public int shoot(int weaponChoice)
        {
            int damage;
            if (weaponChoice == 1)
            {
                damage = (shotgun.damage + bonusDamage);
            }
            else if (weaponChoice == 2)
            {
                damage = (gatlin.damage + bonusDamage);
            }
            else
            {
                damage = (grenageLaunch.damage + bonusDamage);
            }
            return damage;
            
        }
        public void walk()
        {
            bonusDamage += 1;
        }

        
    }
}
