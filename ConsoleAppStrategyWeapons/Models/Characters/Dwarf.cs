using ConsoleAppStrategyWeapons.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Characters
{
    class Dwarf : Character
    {
        public Dwarf()
        {
            this.Name = "Gimli";
            this.MyWeapon = new WarHammer();
        }
    }
}
