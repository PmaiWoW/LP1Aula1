using System;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argument " + (i + 1) + ": " + args[i]);
            }
            Console.Read();//ReadKey doesn't work in Git Bash, use Read instead
        }
    }
}
