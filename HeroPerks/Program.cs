using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">");
            string powers = Console.ReadLine();

            Perks myPerks = 0;

            foreach (char power in powers)
            {
                switch (power)
                {
                    case 'w':
                        myPerks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        myPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        myPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        myPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown Perk!");
                        return;
                }
            }
        }
    }
}
