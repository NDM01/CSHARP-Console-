using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_n_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, num,soma;
            double med;
            soma = 0;
            Console.Write("Insira o número de valores a calcular ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("Insira um número ");
                num = int.Parse(Console.ReadLine());
                soma = soma + num;
            }
            med = soma / n;
            Console.Write("A média é {0}", med);
            Console.ReadKey();
                

        }
    }
}
