using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_pessoas
{
    class Program
    {
        static public void Desconto(String N1,double a)
        {
            double b;
            if (a<=500)
            {
                b= 0.02 * a;
                Console.Write("O desconto é de 2%,tem desconto de {0} euros",b);
                           }
            else
            {
                b = 0.05 * a;
                Console.Write("O desconto é de 5%,tem desconto de {0} euros",b);
            }Console.ReadKey();
                

        }
        
       static void Main(string[] args)
        {
            string N;
            double Va;
            int i;
            for (i = 1;i<= 5;i++)
            {
                Console.Write("Insira o nome do cliente: ");
                N =Console.ReadLine();
                Console.Write("Insira o valor das compras o ano passado: ");
                Va = double.Parse(Console.ReadLine());
                  Desconto(N,Va);
               


            }

               
                              
        }
    }
}
