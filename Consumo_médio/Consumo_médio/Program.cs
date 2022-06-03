using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_médio
{
    class Program
    {
        static void Main(string[] args)
        {
            double CG, DTP, CM;
            Console.Write("Insira a distancia total percorrida pelo automóvel ");
            DTP = double.Parse(Console.ReadLine());
            Console.Write("Insira o total de combustível gasto ");
            CG = double.Parse(Console.ReadLine());
            CM = DTP / CG;
            Console.WriteLine("O consumo médio é {0}", CM);
            Console.ReadKey();
        }
    }
}
