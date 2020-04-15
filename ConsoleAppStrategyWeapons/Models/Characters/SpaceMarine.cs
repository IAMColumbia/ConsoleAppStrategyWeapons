using ConsoleAppStrategyWeapons.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Characters
{
    class SpaceMarine : Character
    {
        public SpaceMarine()
        {
            this.Name = "master cheif";
            this.MyWeapon = new BFG();
        }
    }
}
