using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] vetor = new int[6];
                int i = -1;
                int num, pos = 0;
                string encontrou = "nao";

                for (i = 0; i <= 5; i++)
                {
                    Console.Write("Insira o {0} número: ", i + 1);
                    vetor[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Diga o número que quer procurar: ");
                num = int.Parse(Console.ReadLine());
                for (i = 0; i <= 5; i++)
                {
                    if (vetor[i] == num)
                    {
                        encontrou = "sim";
                        pos = i;
                    }
                }
                if (encontrou == "sim")
                {
                    Console.WriteLine("Encontrou valor na posição {0}", pos + 1);
                }
                else
                {
                    Console.WriteLine("Não Encontrou o Valor");
                }
                Console.ReadKey();



            }
        }
        }
}
