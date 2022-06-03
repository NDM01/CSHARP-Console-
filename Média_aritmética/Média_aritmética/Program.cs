
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_aritmética
{
    //Dada uma lista de 5 valores calcular a sua média aritmética
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            double med,Soma;
            Soma = 0;
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Insira o número ");
                num = int.Parse(Console.ReadLine());
                Soma = Soma + num;
            }
            med = Soma / i;
            Console.Write("A média aritmética é {0}", med);
            Console.ReadKey();


        }
    }
}
