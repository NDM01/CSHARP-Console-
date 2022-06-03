using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, R, vol;
            Console.Write("Insira a altura do cilindro ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Insira o raio ");
            R = double.Parse(Console.ReadLine());
            vol = 3.14 * R * R * 2;
            Console.Write("O volume é {0}", vol);
            Console.ReadKey();

                

        }
    }
}
