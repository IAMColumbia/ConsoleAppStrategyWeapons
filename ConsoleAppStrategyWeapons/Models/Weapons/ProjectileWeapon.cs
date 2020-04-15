using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Weapons
{
    public abstract class ProjectileWeapon : Weapon
    {
        public ProjectileWeapon()
        {
            this.Verb = "Shoot";
        }
    }
}
