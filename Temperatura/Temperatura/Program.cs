using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.Write("Insira a temperatura em graus ");
            c = double.Parse(Console.ReadLine());
            f = c * 1.8 + 32;
            Console.Write("A temeperatura em graus Fahrenheit é {0}",f);
            Console.ReadKey();
                
        }
    }
}
