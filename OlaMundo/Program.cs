using System;

namespace OlaMundo
{
    /// <summary>
    /// Program to write "Hello World!" and "Goodbye World!" on the screen;
    /// Waits for any input to shutdown the program after showing the messages;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bye World!");
            Console.ReadKey();
        }
    }
}
