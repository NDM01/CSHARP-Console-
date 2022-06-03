using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, M;
            Console.Write("Insira a primeira nota ");
            N1 = double.Parse(Console.ReadLine());
            Console.Write("insira a segunda nota ");
            N2 = double.Parse(Console.ReadLine());
            Console.Write("insira a terceira nota ");
            N3 = double.Parse(Console.ReadLine());
            M = (N1 + N2 + N3) / 3;
            if (M > 9.5)
            {
                Console.Write("Passou com {0}", M);
            }
            else
            {
                Console.Write("nâo passou porque teve {0}", M);
            }
            Console.ReadKey();
        }

    }
}
