using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idades_revisao_
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta, contb, soma, contc, max, min, posmax, posmin, i, id, contp, contimp;
            double med;
            soma = 0;
            conta = 0;
            contb = 0;
            contc = 0;
            max = -999;
            min = 999;
            contp = 0;
            contimp = 0;
            posmax = 0;
            posmin = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Insira a idade ");
                id = int.Parse(Console.ReadLine());
                soma = soma + id;
                if (id % 2 == 0)
                {
                    contp = contp + 1;
                }
                else
                {
                    contimp = contimp + 1;
                }
                if (id >= max)
                {
                    max = id;
                    posmax = i;
                }
                if (id <= min)
                {
                    min = id;
                    posmin = i;
                }
                if (id == 15)
                {
                    Console.WriteLine("Jovem");
                    conta = conta + 1;
                }
                else if (id == 1)
                {

                    Console.WriteLine("Bebé");
                    contb = contb + 1;

                }
                else if (id >= 2 & id <= 4)
                {

                    Console.WriteLine("Criança");
                    contc = contc + 1;
                }
                else
                {
                    Console.WriteLine("Adulto");
                }
            }
             Console.WriteLine("O nº de jovens é {0}", conta);
                Console.WriteLine("O nº de bebés é {0}", contb);
                Console.WriteLine("O nº de crianças é {0}", contc);
                med = soma / 5;
                Console.WriteLine("A média das idades é {0}", med);
                Console.WriteLine("O mais velho tem {0} anos e é o aluno {1}", max, posmax);
                Console.WriteLine("O mais novo tem {0} anos e é o aluno {1}", min, posmin);
                Console.WriteLine("Existe {0} idades pares",contp);
                Console.WriteLine("Existe {0} idades impares",contimp);
                Console.ReadKey();
               
                           
                  
        }
    }
}
