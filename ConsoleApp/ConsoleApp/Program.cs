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
            Class1 s = new Class1();
            Class2 r = new Class2();
            Console.WriteLine("La suma de 3 + 3 es " + s.suma(3, 3));
            Console.WriteLine("La resta de 4 - 3 es " + s.resta(4, 3));
            Console.WriteLine("La multiplicación de 4 x 5 es " + r.multi(4, 5));
            Console.WriteLine("La división de 6 / 3 es " + r.divi(6, 3));
        }
    }
}
