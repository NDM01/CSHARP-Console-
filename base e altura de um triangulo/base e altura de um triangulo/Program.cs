using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_e_altura_de_um_triangulo
{
    class Program
    {
        static public double Area(double b1, double a1)
        {
            double a;
            a = (b1 * a1) / 2;
            return a;
        }
        static void Main(string[] args)
        {
            double b, al, ar;
            Console.Write("Insira a base ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Insira a altura ");
            al = double.Parse(Console.ReadLine());
            ar = Area(b, al);
            Console.WriteLine("A área é {0}", ar);
            Console.ReadKey();

        }
    }
}
