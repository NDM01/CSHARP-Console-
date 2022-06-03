using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_semana_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.Write("Insira o dia da semana ");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.Write("Segunda-Feira");
                    break;
                
                case 2: 
                    Console.Write("Terça-Feira");
                     break;
                case 3:
                    Console.Write("Quarta-Feira");
                    break;
                case 4:
                    Console.Write("Quinta-Feira");
                    break;
                case 5:
                    Console.Write("Sexta-Feira");
                    break;
                case 6:
                    Console.Write("Sábado");
                    break;
                case 7:
                    Console.Write("Domingo");
                    break;
                default:
                    Console.Write("Insira um número ente 1 e 7");
                    break;
                                    
            }
            Console.ReadKey();
                  
               
        }
    }
}
