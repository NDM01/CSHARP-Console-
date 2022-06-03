using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static public double Hipotenusa(double c1, double c2)
        {
            return Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));
        }
        static void Main(string[] args)
        {
            double c1, c2, h;
            Console.Write("Valor do cateto 1:");
            c1 = double.Parse(Console.ReadLine());
            Console.Write("Valor do cateto 2:");
            c2 = double.Parse(Console.ReadLine());
            h = Hipotenusa(c1, c2);
            Console.WriteLine("\nHipotenusa: {0}", h);
            Console.ReadKey();
        }
    }
}
