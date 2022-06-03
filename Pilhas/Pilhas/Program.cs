using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            int menu = 0;
            while (menu!=7)
            {
                Console.Clear();
                Console.WriteLine("1- Verificar se Pilha está vazia");
                Console.WriteLine("2- Inserir/Empilhar");
                Console.WriteLine("3- Retirar/Desempilhar");
                Console.WriteLine("4- Tamanho da Pilha");
                Console.WriteLine("5- Mostrar o topo");
                Console.WriteLine("6- Limpar a Pilha");
                Console.WriteLine("7- Sair");
                Console.WriteLine("*****************");
                Console.WriteLine("Insira a opção do Menu: ");
                menu = int.Parse(Console.ReadLine());
                Console.WriteLine("****************");
                switch (menu)
                {
                    case 1:
                        if(pilha.Count==0)
                        {
                            Console.WriteLine("Pilha Vazia");
                        }
                        else
                        {
                            Console.WriteLine("A Pilha tem {0} elementos", pilha.Count);
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Qual o nº que quer inserir ");
                        int v = int.Parse(Console.ReadLine());
                        pilha.Push(v);
                        break;
                    case 3:
                        if(pilha.Count>0)
                        {
                            Console.WriteLine("Retirou o nº {0}", pilha.Pop());
                        }
                        else
                        {
                            Console.WriteLine("A Pilha está vazia não pode retirar nºs");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        int cont = pilha.Count;
                        Console.WriteLine("O  nº de elementos da pilha é {0}", cont);
                        Console.ReadKey();
                        break;
                    case 5:
                        if(pilha.Count!=0)
                        {
                            Console.WriteLine("O nº que está no Topo da pilha é {0} ", pilha.Peek());
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        pilha.Clear();
                        Console.WriteLine("A Pilha foi limpa");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Escolheu Terminar");
                        Console.ReadKey();
                        break;
                   
                }

            }
        }
    }
}
