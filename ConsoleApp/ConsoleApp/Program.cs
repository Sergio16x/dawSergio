using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program
            class1 s = new class1();
            class2 r = new class2();
            Console.WriteLine("La suma de 3 + 3 es " + s.suma(3, 3));
            Console.WriteLine("La resta de 4 - 3 es " + s.resta(4, 3));
            Console.WriteLine("La multiplicación de 4 x 5 es " + s.multi(4, 5));
            Console.WriteLine("La división de 6 / 3 es " + s.divi(6, 3));
        }
    }
}
