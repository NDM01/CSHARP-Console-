using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] notas = new int[5];
            for (i = 0; i < 4; i++)
            {
                Console.Write("Digite a nota do {0} º aluno: ", i);
               
                notas[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("A nota do { 0} º aluno é { 1} ", i, notas[i]);
        }
        Console.ReadKey(); 

        
        }
    }
}
