using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static public bool Par(int a)
        {
            if (a % 2 == 0)
                return true;
        
           else
        
           return false;
        }
        static void Main(string[] args)
        { 
            Console.Write("Introduzaum valor: ");
            int valor = int.Parse(Console.ReadLine());
            if (Par(valor))
            {
                Console.Write("\nO valor é impar.");
            }
            else
            { 
                Console.WriteLine("\nO valor é impar");
            } Console.ReadKey();

        }
    }
}
