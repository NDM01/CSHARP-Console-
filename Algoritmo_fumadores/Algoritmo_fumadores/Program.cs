using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa que le para 3 fumadores o nº de cigarros que fuma por dia, o nº de anos que fuma e o preço do maço e calcula o valor gasto em tabaco.
namespace Algoritmo_fumadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double cg,an,ad,M,D,P,pr;
            int i;
            for (i=1;i<=3;i++)
            {
                Console.Write("Insira o nº de cigarros que fuma por dia ");
                cg = double.Parse(Console.ReadLine());
                Console.Write("Insira a quantos anos fuma ");
                an = double.Parse(Console.ReadLine());
                ad = 365 * an;
                Console.Write("Insira o preço de cada maço ");
                M = double.Parse(Console.ReadLine());
                D = ad * cg;
                P = D / 20;
                pr = P * M;
                Console.WriteLine("Ao final de {0} anos gastou {1} euros em tabaco ",an,pr);
                    

            }Console.ReadKey();
            
        }
    }
}
