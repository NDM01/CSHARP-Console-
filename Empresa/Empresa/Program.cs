using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double codf, sal, fm, Dif;
            int i;
            for (i = 1; i <= 4; i++)
            {
                Console.Write("Insira o código do funcionário ");
                codf = double.Parse(Console.ReadLine());
                Console.Write("Insira o salário do funcionário ");
                sal = double.Parse(Console.ReadLine());
                if (codf == 101)
                {
                    fm = sal * 0.10;
                    Dif = sal + fm;
                    Console.Write("O seu cargo é gerente e vai receber um extra de {0}, vai começar a receber {1}", fm, Dif);
                }
                else if (codf == 102)
                {
                    fm = sal * 0.20;
                    Dif = sal + fm;
                    Console.Write("O seu cargo é Engenheiro e vai receber um extra de {0}, vai começar a receber {1}", fm, Dif);
                }
                else if (codf == 103)
                {
                    fm = sal * 0.30;
                    Dif = sal + fm;
                    Console.Write("O seu cargo é Técnico e vai receber um extra de {0}, vai começar a receber {1}", fm, Dif);
                }
                else
                {
                    fm = sal * 0.40;
                    Dif = sal + fm;
                    Console.Write("Vai receber um extra de {0}, vai começar a receber {1}", fm, Dif);
                }
                Console.ReadKey();

            }
        }
    }
}
