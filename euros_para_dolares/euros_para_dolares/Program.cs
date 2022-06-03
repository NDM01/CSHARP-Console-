using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euros_para_dolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Double E, D;
            Console.Write("Insira o valor em euros ");
            E = double.Parse(Console.ReadLine());
            D = E * 1.98;
                Console.Write("O valor em dolares é {0}", D);
            Console.ReadKey();
        }
    }
}
