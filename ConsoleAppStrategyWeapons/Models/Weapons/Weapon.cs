using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public int Damage { get; set; }
        public string Name { get ; set; }
        public string Verb { get ; set; }

        public Weapon()
        {
            this.Name = "Sword";
            this.Damage = 7;
            this.Verb = "Swing";
        }
        
        public string Use()
        {
            return $"{this.Verb} that {this.Name}";
        }
    }
}
