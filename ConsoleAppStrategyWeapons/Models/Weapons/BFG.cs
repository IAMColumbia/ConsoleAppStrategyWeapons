using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Weapons
{
    class BFG : ProjectileWeapon
    {
        public BFG()
        {
            this.Name = "Big Friggin Gun";
            this.Damage = Int32.MaxValue;
            
        }
    }
}
