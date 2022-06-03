using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_semana_if_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.Write("Insira o dia da semana ");
            dia = int.Parse(Console.ReadLine());
            if (dia == 1) 
            {
                Console.Write("Segunda-Feira");
            }
            else if (dia == 2)
            {
                Console.Write("Terça-Feira");
            }
            else if (dia == 3)
            {
                Console.Write("Quarta-Feira");
            }
            else if (dia == 4)
            {
                Console.Write("Quinta-Feira");
            }
            Console.ReadKey();


       
        }
    }
}
