using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raio_de_um_círculo
{
    class Program
    {
        static public double Area(double r1)
        {
            double a;
            a = 3.14 * r1 * r1;
            return a;
        }
            

        static void Main(string[] args)
        {
                double R, ar;
                Console.Write("Insira o raio ");
                R = double.Parse(Console.ReadLine());
                ar = Area(R);
                Console.WriteLine("A área é {0}", ar);
                Console.ReadKey();

            }
    }
}
