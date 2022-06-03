using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Program
    {
        static public double Menor(double x, double y)
        {
            if (x < y)
                return x;
            else
                return y;
        }
    
        static void Main(string[] args)
        {
            double a,b, min;
            Console.Write("Insira o primeiro número ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número ");
            b = double.Parse(Console.ReadLine());
            min = Menor(a, b);
            Console.WriteLine("O menor entre {0} e {1} é {2}", a, b, min);
            Console.ReadKey();
            
        }
    }
}
