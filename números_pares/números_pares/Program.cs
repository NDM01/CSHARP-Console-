using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace números_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Insira o número ");
            n1=int.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("O número {0} é positivo", n1);
            }
            else
            {
                Console.WriteLine("O número {0} é negativo", n1);
            }
            if (n1 % 2 == 0) 
            {
                Console.WriteLine("O número é par");
            } 
             else
            {
                Console.WriteLine("O número é ímpar");
            }
            Console.ReadKey();
                
               
        }
    }
}
