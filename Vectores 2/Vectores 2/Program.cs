using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0;
            double media;
            int[] notas = new int[10];
            for (i = 0; i < = 9; i++)
            {
                Console.Write("Digite a nota do {0} º aluno: ", i+1);
               
                notas[i] = int.Parse(Console.ReadLine());
                soma = soma + notas[i];
            }
            media = soma / 10;
            Console.WriteLine("A média das notas dos 10 alunos é { 0} ", media);
            for (i = 0; i < = 9; i++)
            {
                Console.WriteLine("A nota do { 0} º aluno é { 1} : ", i + 1, notas[i]);
        }
        Console.ReadKey(); 
        }
    }
}
