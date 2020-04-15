using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStrategyWeapons.Models.Characters
{
    public interface IDamageable
    {
        int HitPoints { get; set; }
        void TakeDamage(int HowMuch);
    }
}
