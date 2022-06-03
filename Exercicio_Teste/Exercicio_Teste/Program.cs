using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, h,imc;
            int i;
            for (i=1;i<=4;i++)
            {
                Console.Write("Insira o peso ");
                p = double.Parse(Console.ReadLine());
                Console.Write("Insira a altura ");
                h = double.Parse(Console.ReadLine());
                imc = p / (h * h);
                if (imc<=19)
                {
                    Console.WriteLine("Está a baixo do peso,o seu indice de massa corporal é {0}",imc);
                    
                }
                else if(imc>20 && imc<=25)
                {
                    Console.WriteLine("O seu peso esta normal,e o seu indice de massa corporal é {0}", imc);
                }
                else if (imc>=26)
                {
                    Console.WriteLine("Está a cima do peso, o seu indice de massa corporal é {0}", imc);
                } Console.ReadKey();



            }
        }
    }
}
