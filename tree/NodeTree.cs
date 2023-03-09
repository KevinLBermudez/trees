using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees.tree
{
    public class NodeTree
    {
        // data miembro de la clase NodeTree
        public NodeTree leftNode;
        public NodeTree rightNode;
        public int data;
        //inicializar data y hacer de este nodo un nodo hoja
        public NodeTree(int datosNodo)
        {
            data = datosNodo;
            leftNode = rightNode = null;
            //el nodo no tiene hijos
        }
        //insert un nuevo 
        public void insert(int valueInsert)
        {
            //insert un subárbol right
            if (valueInsert > data)
            {
                //insert un nuevo NodeTree
                if (rightNode == null)
                    rightNode = new NodeTree(valueInsert);
                else
                    //continuar reccorriendo el subárbol right
                    rightNode.insert(valueInsert);
            }
            //insert un subárbolizquierdo
            else //if (valueInsert < data)
            {
                //insert un nuevo NodeTree
                if (leftNode == null)
                    leftNode = new NodeTree(valueInsert);
                else
                    //continuar reccorriendo el subárbol left
                    leftNode.insert(valueInsert);
            }
        }
    }
}
