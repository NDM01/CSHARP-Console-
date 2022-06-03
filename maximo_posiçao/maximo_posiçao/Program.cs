using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximo_posiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, v, Max, pos1;
            Max = -999;
            pos1 = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Insira um número ");
                v = int.Parse(Console.ReadLine());
                if (v >= Max)
                {
                    Max = v;
                    pos1 = i;
                }
            }
            Console.Write("O maior número é {0} ", Max);
            Console.Write("Está na posição {0}", pos1);
            Console.ReadKey();

               
    
        }
    }
}
