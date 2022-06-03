using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,max,min,cont1,cont2,r;
            int i;
            max = -999;
            min = 999;
            cont1 = 0;
            cont2 = 0;
            for (i = 1; i <= 6; i++)
            {
                
                Console.Write("Insira o número ");
                n = double.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("O número é par ");
                    cont1 = cont1 + 1;
                }
                else
                {
                    Console.WriteLine("O número é ímpar ");
                    cont2 = cont2 + 1;
                }
                if(n<=min)
                {
                    min = n;
                   
                }
                else if(n>=max)
                {
                    max = n;
                  

                }
                r = Math.Sqrt(n);
                Console.WriteLine
                    ("A raiz do número é {0}", r);
                


            }
            Console.WriteLine("O menor número é {0}", min);
            Console.WriteLine("O maior número é {0}", max);

            Console.ReadKey();

        }
    }
}
