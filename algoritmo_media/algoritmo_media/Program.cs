using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo_media
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Soma, v;
            double m;
            Soma = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Insira o valor ");
                v = int.Parse(Console.ReadLine());
                Soma = Soma + v;
            }
            m = Soma / 5;
            Console.Write("A média aritmética é {0}", m);
            Console.ReadKey();

        }
    }
}
