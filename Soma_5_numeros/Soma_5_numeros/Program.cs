using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_5_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Soma, n, i;
            Soma = 0;
            for (i = 1; i <= 5; i++) 
            {
                Console.Write("Insira um número ");
                n = int.Parse(Console.ReadLine());
                Soma = Soma + n;
            }
            Console.Write("A soma é {0}", Soma);
            Console.ReadKey();
              

        }
    }
}
