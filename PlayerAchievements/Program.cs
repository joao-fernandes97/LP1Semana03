using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players?");
            int n = int.Parse(Console.ReadLine());

            Achievements[] completion = new Achievements[n];

            for (int i = 0; i < completion.Length; i++)
            {
                for (int j = 1; j< (1 << 3); j = j << 1)
                {
                    Console.Write($"Player {i+1}, did you {(Achievements)j}? (T/F)");
                    string answer = Console.ReadLine();

                    if(answer=="T")
                    {
                        completion[i] ^= (Achievements)j;
                    }

                }
            }

            for (int k = 0; k < completion.Length; k++)
            {
                Achievements completionist = 
                    Achievements.DefeatOptionalBoss |
                    Achievements.FindHiddenLevel |
                    Achievements.FinishGame;                        

                bool isCompletionist = completion[k] == completionist;

                Console.Write(completion[k]);
                if(isCompletionist)
                {
                    Console.WriteLine(", Completionist!");
                } else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
