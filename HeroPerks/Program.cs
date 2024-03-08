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
            if(myPerks!=0)
            {
                Console.WriteLine(myPerks);
            }else
            {
                Console.WriteLine("No perks at all!");
            }
            if((myPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }
            if((myPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
