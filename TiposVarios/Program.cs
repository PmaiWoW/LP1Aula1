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
            int i = 1;

            //1.1 - Hexadecimal
            int i1 = 0x15;
            uint j1 = 0x18U;

            //1.2 - binário
            int i2 = 0b01111001;
            //testar com underscore
            int i3 = 0b0111_1001;

            //1.3 - longs
            long l = 9L;
            ulong uL = 9UL;

            Console.WriteLine(string.Format("Inteiros:\n" +
                "int: {0}, hexadec int:{1}, hexadec unsigned int:{2}, " +
                "binary int:{3}, binary int(c/ underscore):{4}, " +
                "long:{5}, unsigned long:{6}", i, i1, j1, i2, i3, l, uL));

            //2 - Chars
            char omegaSymbol = '\u03A9';
            char newLine = '\u000A';
            char o = '\u004F';
            char m = '\u004D';
            char e = '\u0045';
            char g = '\u0047';
            char a = '\u0041';

            Console.WriteLine("\nChars:{0}  {1}{0}" +
                "Nome(chars em unicode): {2}{3}{4}{5}{6}"
                ,newLine,omegaSymbol,o,m,e,g,a);

            //3 - Reais
            float f = 7.5363f;
            double d = 8.3261;
            decimal z = 5.2364m;

            Console.WriteLine("\nReais:\nfloat:{0}\ndouble:{1}\ndecimal:{2}", 
                f, d, z);

            //4 - Booleanas
            bool bool1 = true;
            bool bool2 = false;

            Console.WriteLine("\nBooleanas:\nVerdadeiro: {0}\nFalso: {1}",
                bool1, bool2);

            Console.ReadKey();
        }
    }
}
