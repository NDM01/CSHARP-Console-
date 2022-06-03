using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_preço
{
    class Program
    {
        static public double Preco(double preco,int quanti)
        {
            double a;
            a = preco * quanti;
            return a;

        }
        static void Main(string[] args)
        {
            double pr,prf;
            int quan,i;
            for (i= 1;i<= 5;i++)
            {
                Console.Write("\nInsira o preço do {0} produto ",i);
                pr = double.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de produtos ");
                quan = int.Parse(Console.ReadLine());
                prf = Preco(pr, quan);
                Console.Write("O preço final é de {0}", prf);
            }Console.ReadKey();
            

        }
    }
}
