using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_peso
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, i, p;
            double med;
            soma = 0;
            for (i = 1; i <= 20; i++) 3
                    4
            {
                Console.Write("Insira o peso ");
                p = int.Parse(Console.ReadLine());
                soma = soma + p;
            }
            med = soma / 20;
            Console.Write("A média dos pesos é {0}", med);
            Console.ReadKey();
        }
    }
}
