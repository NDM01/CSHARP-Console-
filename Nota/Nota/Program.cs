using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            double NT, NTP, NR, MA;
            Console.Write("Insira a nota do teste ");
            NT = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota do trabalho prático ");
            NTP = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota do relatório ");
            NR = double.Parse(Console.ReadLine());
            MA = (NT * 0.30 + NTP * 0.50 + NR * 0.20);
            Console.Write("A média das notas do aluno é {0}", MA);
            Console.ReadKey();

        }
    }
}
