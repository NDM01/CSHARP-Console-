using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, S, P, SP;
            Console.Write("Insira o primeiro número ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número ");
            N2 = int.Parse(Console.ReadLine());
            S = N1 + N2;
            P = N1 * N2;
            SP = S + P;
            Console.WriteLine("O valor do produto e da soma é {0}", SP);
            Console.ReadKey();

        }
    }
}
