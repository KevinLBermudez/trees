using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using trees.Inputs;
using trees.tree;

namespace trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            
            Tree tree = new Tree();
            int valor = 0;
            ConsoleKey key;

            Console.WriteLine("Insertar los valores al Tree");

            do
            {
                try
                {
                    valor = input.GetInt();
                    tree.insertNode(valor);
                    printMessage(ConsoleColor.Green, "Node added");
                    printMessage(ConsoleColor.Blue, "Press Enter to add a new node, press Esc for exit");
                    key = Console.ReadKey().Key;
                    if(key == ConsoleKey.Escape)
                    {
                        break;
                    }


                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            } while(true);

            printMessage(ConsoleColor.Blue, "Al recorrer el Tree de manera Preorden es:");
            tree.preOrder();
            printMessage(ConsoleColor.Red, "Al recorrer el Tree de manera Inorden es:");
            tree.inOrder();
            printMessage(ConsoleColor.Green, "Al recorrer el Tree de manera Postorden es:");
            tree.postOrder();
            Console.ReadKey();
        }
        public static void printMessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
