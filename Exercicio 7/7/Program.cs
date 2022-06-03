using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static int Menu()
        {
            int op;
            Console.Clear();
            Console.WriteLine("MENU:  ");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("| 1: Perimetro de uma circunferência ");
            Console.WriteLine("| 2: Área de um círculo              |");
            Console.WriteLine("| 3: Volume de uma esfera            |");
            Console.WriteLine("| 4: Superfície de uma esfera        |");
            Console.WriteLine("| 5: Sair                            |");
            Console.WriteLine("+----------------------------+");
            do
            {
                Console.WriteLine();
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 5);
            return op;
        }
        static void PerimetroCircunderencia()
        {
            Console.Write("\nIntroduza o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double perimetro = 2 * Math.PI * raio;
            Console.WriteLine("\nPerímetro:" + perimetro);
        }
        static void AreaCirculo()
        {
            Console.Write("\nIntroduza o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * raio * raio;
            Console.WriteLine("\nÁrea: " + area);
        }
        static void VolumeEsfera()
        {
            Console.Write("\nIntroduza o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = 4 / 3 * Math.PI * raio * raio;
            Console.WriteLine("\nVolume: " + volume);
        }
        static void SuperficieEsfera()
        {
            Console.Write("\nIntroduza o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double superficie = 4 * Math.PI * raio * raio;
            Console.WriteLine("\nSuperfície: " + superficie);
        }
        static void Main(string[] args)
        {
            int op;
            do
            {
                op = Menu();
                switch (op)
                {
                    case 1: PerimetroCircunderencia(); break;
                    case 2: AreaCirculo(); break;
                    case 3: VolumeEsfera(); break;
                    case 4: SuperficieEsfera(); break;
                }
                Console.WriteLine("\nPrima <Enter> para continuar...");
                Console.ReadKey();
            } while (op != 5);
                


        }
    }
}
