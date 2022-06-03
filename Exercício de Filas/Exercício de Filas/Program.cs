using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            int menu = 0;
            while (menu != 8)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1- Verificar se a fila está vazia");
                Console.WriteLine("2- Inserir");
                Console.WriteLine("3- Mostrar elementos da fila");
                Console.WriteLine("4- Eliminar");
                Console.WriteLine("5 - Mostrar 1º elemento da fila");
                Console.WriteLine("6- Tamanho da fila");
                Console.WriteLine("7- Limpar a Fila");
                Console.WriteLine("8- Sair");
                Console.WriteLine("****************");
                Console.Write("Insira a opção do Menu: ");
                menu = int.Parse(Console.ReadLine());
                Console.WriteLine("****************");
                switch(menu)
                {
                    case 1:
                        if (fila.Count == 0) 
                        {
                            Console.WriteLine("Fila Vazia");
                        }
                        else
                        {
                            Console.WriteLine("A Fila tem {0} elementos", fila.Count);
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Qual o nº que quer inserir ");
                        int v = int.Parse(Console.ReadLine());
                        fila.Enqueue(v); 
                        
                     break;
                    case 3:
                        foreach (int num in fila)
                            Console.Write("{0} ", num);
                        Console.ReadKey();
                        break;
                    case 4:
                        if (fila.Count > 0)
                        {
                            Console.WriteLine("Retirou o nº {0}", fila.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia nao pode retirar nºs");
                        }
                        Console.ReadKey();
                        break;
                       case 5:
                        if(fila.Count !=0)
                        {
                            Console.WriteLine("O 1º nº da fila é {0}", fila.Peek());
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        int cont = fila.Count;
                        Console.WriteLine("A Fila foi limpa");
                        Console.ReadKey();
                        break;
                    case 7:
                        fila.Clear();
                        Console.WriteLine("A Fila foi limpa");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Escolheu Terminar");
                        Console.ReadKey();
                        break;

                }
            
            }
            }
    }
}
