using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==6){
                float[,] matrixA = new float[2,2];
                matrixA[0,0]=float.Parse(args[0]);
                matrixA[0,1]=float.Parse(args[1]);
                matrixA[1,0]=float.Parse(args[2]);
                matrixA[1,1]=float.Parse(args[3]);
        
                float[,] matrixB = new float[1,2];
                matrixB[0,0]=float.Parse(args[4]);
                matrixB[0,1]=float.Parse(args[5]);

            } else
            {
                Console.WriteLine("Not enough args");
            }
        }
    }
}
