using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Haftauc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci uygulama");
            Console.WriteLine(48 / 6 / 4);
            Console.WriteLine(24 / 3 * 2);
            Console.WriteLine(2 * 2 + 5 - 1 + 4);
            Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);
            Console.WriteLine((5 - 1) * 2 - 1 + 7 * 7 / 2);

            Console.WriteLine("ikinci uygulama");
            byte x = 20, y = 13, z = 42;
            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);
            Console.WriteLine(23 >= 23 && 45 != 18);
            Console.WriteLine(x > y && z == y && z < x);
            Console.WriteLine(z > x && y < x);
            Console.WriteLine(x != z || y <= z);

            Console.ReadLine();
        }
    }
}