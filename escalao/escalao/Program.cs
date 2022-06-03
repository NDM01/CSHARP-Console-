using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escalao
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.Write("Insira a idade ");
            id = int.Parse(Console.ReadLine());
            switch (id)
            {
                case 5:
                case 6:
                case 7:
                    Console.Write("Infantil A");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.Write("Infantil B");
                    break;
                case 11:
                case 12:
                case 13:
                    Console.Write("Juvenil A");
                    break;
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.Write("juvenil B");
                    break;
                case 18:
                case 19:
                case 20:
                    Console.Write("Adulto");
                    break;
                default:
                    Console.Write("inscriçôes a partir dos 5 ate aos 20");
                    break;
            }
            Console.ReadKey();


            }
        }
    }

