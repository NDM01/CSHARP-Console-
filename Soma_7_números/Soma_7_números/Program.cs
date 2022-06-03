using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_7_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, i, n;
            soma = 0;
            for (i = 1; i <= 7; i++)
            {
                Console.Write("Insira o número ");
                n = int.Parse(Console.ReadLine());
                soma = soma+n;
            }
            Console.Write("A soma dos números é {0}", soma);
            Console.ReadKey();


        }
    }
}
