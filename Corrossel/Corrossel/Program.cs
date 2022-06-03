using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrossel
{
    class Program
    {
        static void Main(string[] args)
        {
            double al;
            int i,id;
                for(i=1;i<=4;i++)
                {
                Console.Write("Insira a altura da criança ");
                al = int.Parse(Console.ReadLine());
                Console.Write("Insira a idade da criança ");
                id = int.Parse(Console.ReadLine());
                if (al>=110 && id>=10)
                {
                    Console.WriteLine("Pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode entrar");


                }Console.ReadKey();
                

                }

            
        }
    }
}
