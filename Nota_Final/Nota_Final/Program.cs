using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            double Notaperiodo, notateste, NF;
            Console.Write("Insira a nota do terceiro período ");
            Notaperiodo = double.Parse(Console.ReadLine());
            Console.Write("Insira a nota do teste intermédio ");
            notateste = double.Parse(Console.ReadLine());
            NF = (3 * Notaperiodo + notateste) / 4;
            Console.WriteLine("A nota final é {0}", NF);
            Console.ReadKey();


        }
    }
}
