using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Weapons
{
    public interface IWeapon
    {
        int Damage { get; set; }
        string Name { get; set; }
        string Verb { get; set; }

        string Use();  //might chane this later
    }
}
