using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestações
{
    class Program
    {
        static void Main(string[] args)
        {
            double PP, PR;
            Console.Write("Insira o preço dos produtos ");
            PP = double.Parse(Console.ReadLine());
            PR = PP / 5;
                Console.Write("O valor de cada prestação é {0}", PR);
            Console.ReadKey();
             
        }
    }
}
