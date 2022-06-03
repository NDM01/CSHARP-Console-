using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace soma_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, i,N;
            soma = 0;
            for (i = 1; i <= 10; i++) ;
            {
                Console.Write("Insira um número");
                N = double.Parse(Console.ReadLine());
                soma = soma + N;
            }
            Console.Write("A soma é {0}",soma);
            Console.ReadKey();



                      
        
        }
    }
}
