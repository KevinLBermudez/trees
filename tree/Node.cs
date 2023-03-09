using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees.tree
{
    internal class Node
    {
        public Node root = null; //raíz del árbol
      
            public double date;
            /*date es la variable que guarda 
            el date contenido en el Node*/

            public Node left;
            //raíz del subárbol left

            public Node right;
            //raíz del subárbol right

            public Node() { }
            //constructor
        
    }
}
