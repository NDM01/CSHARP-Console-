using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static private void Cabecalho(int n)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" * |");
            for (int i = 1; i <= n; i++) 
            Console.Write("{0,4}", i);
            Console.WriteLine();

        }
        
        static private void Separador(int n)
        {
         Console.Write("---|");
            for(int i=1; i<=n; i++)
                Console.Write("----", i);
            Console.WriteLine();
        }
        static private void Linha(int i, int n)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,3}|", i);
            Console.ForegroundColor = ConsoleColor.White;
            //Cada valor corresponde ao numero da linha a multiplicar pelo valor da coluna
            for (int j = 1; j <= n; j++)
                Console.Write("{0,4}", i * j);
            Console.WriteLine();
        }
        static public void Tabela(int n)
        {
            Cabecalho(n);
            Separador(n);
            for (int i = 1; i <=n; i++)
                Linha(i, n);
        
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um valor:");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            Tabela(n);
            Console.ReadKey();
        }
    }
}
