using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_Pitágoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double cat1, cat2, hip;
            Console.Write("Insira o valor do cateto1 ");
            cat1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do cateto2 ");
            cat2 = double.Parse(Console.ReadLine());
            hip = (cat1 * cat1) + (cat2 * cat2);
           
            Console.Write("O valor da hipotenusa é de {0}", hip);
            Console.ReadKey();




        }
    }
}
