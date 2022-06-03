using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static int Idade(DateTime dataNascimento)
        {
            DateTime hoje;
            hoje = DateTime.Now;
            if (dataNascimento.Month > hoje.Month || (dataNascimento.Month == hoje.Month && dataNascimento.Day > hoje.Day))
                return hoje.Year - dataNascimento.Year - 1;
            else
                return hoje.Year - dataNascimento.Year;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduza a data de nascimento: ");
            DateTime dn = DateTime.Parse(Console.ReadLine());
            int idade = Idade(dn);
            Console.WriteLine("Idade: " + idade);
            Console.ReadKey();


        }
    }
}
