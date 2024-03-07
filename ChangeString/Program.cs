using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a sentence:");
            string sen = Console.ReadLine();
            Console.Write("Type a single character:");
            string cha = Console.ReadLine();

            string output = "";
            foreach (char letter in sen)
            {
                if(letter == Char.Parse(cha))
                {
                    output += "X";
                }else
                {
                    output += letter.ToString();
                }
            }
            
            Console.Write(output);
        }
    }
}
