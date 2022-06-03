using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PP,Pfinal;
            float tx;
            Console.Write("Insira o preço do produto ");
            PP = double.Parse(Console.ReadLine());
          Console.Write("Insira a taxa do iva ");
            tx = float.Parse(Console.ReadLine());
            Pfinal = PP + PP * tx;
            Console.WriteLine("O preço do produto é {0},o preço final é {1}",PP,Pfinal);
            Console.ReadKey();

        }
    }
}
