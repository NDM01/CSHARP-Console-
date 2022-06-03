using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nºhoras
{
    class Program
    {
        static public void Pagamento (int h)

        {
            
            
            if (h <= 2)
            {
                Console.WriteLine("Irá receber 3 euros");
              
            }
            else  if (h >= 3 && h <= 10)
           
            {
                Console.WriteLine("Irá receber 20 euros");
                

            } 
            else if (h>=11)
            {
                Console.WriteLine("Irá receber 40 euros");
               
            } 
        }
            
            
            
        static void Main(string[] args)
        {
            int h, i;
            
            for (i = 1; i <= 4; i++) 
            {
             Console.Write("Insira o nº de horas que o funcionario trabalhou ");
            h = int.Parse(Console.ReadLine());
             Pagamento(h);

            
               
                        

            } Console.ReadLine();



            

        }
    }
}
