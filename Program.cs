using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int n1 = 0;
            Console.WriteLine("tabuada de um numero");
            Console.Write("informe um numero");
            entrada=Console.ReadLine();
            n1= Convert.ToInt32(entrada);

            Console.WriteLine("tabuada do" + n1);
            Console.WriteLine("1x" + n1 + "=" + (1 * n1));
            Console.WriteLine("2x" + n1 + "=" + (2 * n1));
            Console.WriteLine("3x" + n1 + "=" + (3 * n1));
            Console.WriteLine("4x" + n1 + "=" + (4 * n1));
            Console.WriteLine("5x" + n1 + "=" + (5 * n1));
            Console.WriteLine("6x" + n1 + "=" + (6 * n1));
            Console.WriteLine("7x" + n1 + "=" + (7 * n1));
            Console.WriteLine("8x" + n1 + "=" + (8 * n1));
            Console.WriteLine("9x" + n1 + "=" + (9 * n1));
            Console.WriteLine("10x" + n1 + "=" + (10 * n1));
            Console.ReadLine();
        }
    }
}
