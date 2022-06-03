using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioquadro_2
{
    class Program
    { 
       static public int Verificar(int num1)
        {  
            if(num1>=10)
            {
                return num1;
            }
            else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            int num, v;
            Console.Write("Insira um nº ");
            num = int.Parse(Console.ReadLine());
            v = Verificar(num);
            if ( v != 0)
            {
                Console.Write("O nº {0} é maior que 10 ",num);
            }
            else
            {
                Console.Write("O nº {0} é menor que 10 ",num);

            } Console.ReadKey();

        
        }
    }
}
