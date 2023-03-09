using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees.Inputs
{
    internal class Input
    {
        public int GetInt()
        {
            int number = 0;
            string num;
            
            do
            {
                Console.WriteLine("enter the node value");
                
                num = Console.ReadLine();
                
                if(num.ToLower() == "salir")
                {
                    throw new Exception("El usuario ha decidido salir del programa");
                }
                

            } while (!int.TryParse(num, out number));

            
            return number;
        }

    }
}
