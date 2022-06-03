using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static public double Soma(double a, double b)
        {
            return a + b;
        }
        

        static void Main(string[] args)
        {
            double valor1, valor2, resultado;
            Console.WriteLine("Introduz dois valores ");
            valor1 = double.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());
            resultado = Soma(valor1, valor2);
            Console.WriteLine("\nSoma:{0}", resultado);
            Console.ReadKey();


        }
    }
}
