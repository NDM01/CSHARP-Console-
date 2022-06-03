using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, p;
            Console.Write("Insira o raio ");
                r = double.Parse(Console.ReadLine());
                a = 3.14 * r * r;
                p = 2 * 3.14 * r;
                Console.Write("A área é {0}", a, ",o perímetro é {1}", p);
            Console.ReadKey();


           
        }
    }
}
