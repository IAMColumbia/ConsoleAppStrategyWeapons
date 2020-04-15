using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Weapons
{
    public abstract class Hand2Hand : Weapon
    {
        public Hand2Hand()
        {
            this.Verb = "Swing";
        }

    }
}
