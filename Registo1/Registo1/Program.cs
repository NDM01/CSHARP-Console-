using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registo1
{
    class Program
    {
        public struct empregados
        {
            public string nome;
            public string morada;
            public string localidade;
            public int idade;
        }
        
        static void Main(string[] args)
        {
            int i;
            empregados[] pessoas = new empregados[4];
            for(i=0;i<=3;i++)
            {
                Console.Write("Insira o nome da {0}ª pessoa: ", i + 1);
                pessoas[i].nome = Console.ReadLine();
                Console.Write("Insira a morada da {0}ª pessoa: ", i + 1);
                pessoas[i].morada = Console.ReadLine();
                Console.Write("Insira a localidade da {0}ª pessoa: ", i + 1);
                pessoas[i].localidade = Console.ReadLine();
                Console.Write("Insira a idade da {0}ª pessoa: ", i + 1);
                pessoas[i].idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Nome\tMorada\tlocalidade\tidade");
            for(i=0;i<=3;i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", pessoas[i].nome, pessoas[i].morada, pessoas[i].localidade, pessoas[i].idade);

            }
            Console.ReadKey();
        
        }
    }
}
