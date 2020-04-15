using ConsoleAppStrategyWeapons.Models.Characters;
using ConsoleAppStrategyWeapons.Models.Weapons;
using System;

namespace ConsoleAppStrategyWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Character steve = new Knight();
            steve.GiveWeapon(new WarHammer());
            Character gimli = new Dwarf();

            SpaceMarine sm = new SpaceMarine();

            Console.WriteLine(steve.UseWeapon(gimli));
            Console.WriteLine(sm.UseWeapon(steve));


        }
    }
}
