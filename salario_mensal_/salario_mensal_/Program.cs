using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_mensal_
{
    class Program
    {
        static void Main(string[] args)
        {
            int SI;
            double D, SM;
                Console.Write("Insira o salário iliquido ");
            SI = int.Parse(Console.ReadLine());
            Console.Write("Insira o desconto ");
            D = Double.Parse(Console.ReadLine());
            SM = SI - SI * 0.15 - D;
            Console.Write("O salário mensal é de {0}", SM);
            Console.ReadKey();

        }
    }
}
