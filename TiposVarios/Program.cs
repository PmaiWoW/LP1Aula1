using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Inteiros
            //1.1 - Hexadecimal
            int i1 = 0x15;
            uint j1 = 0x18U;
            //1.2 - binário
            int i2 = 0b01111001;
            //testar com underscore
            int i3 = 0b0111_1001;
            long l = 9L;
            ulong uL = 9UL;
            Console.WriteLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}", i1, j1, i2, i3, l, uL));
            Console.ReadKey();
        }
    }
}
