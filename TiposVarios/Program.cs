using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

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

            Console.WriteLine(string.Format("Inteiros:\n" +
                "{0},{1},{2},{3},{4},{5}", 
                i1, j1, i2, i3, l, uL));

            //2 - Chars
            char omegaSymbol = '\u03A9';
            char newLine = '\u000A';
            char o = '\u004F';
            char m = '\u004D';
            char e = '\u0045';
            char g = '\u0047';
            char a = '\u0041';

            Console.WriteLine("Chars:{0} {1}{0}{2}{3}{4}{5}{6}"
                ,newLine,omegaSymbol,o,m,e,g,a);

            Console.ReadKey();
        }
    }
}
