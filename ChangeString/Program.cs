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

            string output = sen + " " +cha;
            Console.Write(output);
        }
    }
}
