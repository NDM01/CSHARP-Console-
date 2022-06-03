using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;
            Console.Write("Insira o primeiro número ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número ");
            N2 = int.Parse(Console.ReadLine());
            if (N1 > N2)
            {
                Console.Write("o maior número é {0}", N1);

            }
            else if (N1 == N2)
            {
                Console.Write("são iguais");

            }
            else
            {
                Console.Write("O maior é {0}", N2);
            }
            Console.ReadKey();
                
        }
    }
 } 
