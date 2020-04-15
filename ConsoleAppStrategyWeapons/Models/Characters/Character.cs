using ConsoleAppStrategyWeapons.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Characters
{
    public abstract class Character : IDamageable
    {
        public int HitPoints { get; set; }
        public string Name { get; set; }

        protected Weapon MyWeapon;

        public Character()
        {
            this.Name = "Steve";
            this.HitPoints = 20;
            this.MyWeapon = new Sword();
        }

        public void GiveWeapon(Weapon w)
        {
            this.MyWeapon = w;
        }

        public string UseWeapon(Character otherCharacter)
        {
            otherCharacter.TakeDamage(this.MyWeapon.Damage);
            return $"{this.Name} {this.MyWeapon.Use()} at {otherCharacter.Name} it causes {this.MyWeapon.Damage} {otherCharacter.Name} HP: {otherCharacter.HitPoints}";
        }

        public void TakeDamage(int HowMuch) 
        {
            this.HitPoints -= HowMuch;
        }
    }
}
