using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players?");
            int n = int.Parse(Console.ReadLine());

            Achievements[] playerAchievemnts = new Achievements[n];

            Console.WriteLine(playerAchievemnts.Length);
        }
    }
}
