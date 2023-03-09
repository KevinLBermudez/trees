using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees.tree
{
    internal class Tree
    {
        public NodeTree raiz;
        //insert un nuevo nodo en el árbol de búsqueda binaria
        //construir un objeto árbol vacío de enteros
        
        
        public Tree()
        {
            raiz = null;
        }
        
        public void insertNode(int valorInsertar)
        {
            try
            {
                if (raiz == null)
                    raiz = new NodeTree(valorInsertar);
                //se crea el nodo raíz
                else
                    raiz.insert(valorInsertar);
                //llamar al método insert
            }
            catch
            {
                throw new Exception("Error when inserting the node in the tree");
            }

        }
        //empezar el recorrido preorden
        public void preOrder()
        {
            helperPreOrder(raiz);
        }
        //método recursivo para realizar recorrido preorden
        public void helperPreOrder(NodeTree nodo)
        {
            if (nodo == null)
                return;
            Console.WriteLine(nodo.data + " ");
            //mostrar data del nodo
            helperPreOrder(nodo.leftNode);
            //recorrer subárbol left
            helperPreOrder(nodo.rightNode);
            //recorrer subárbol right
            
        }
        //empezar el recorrido inorden
        public void inOrder()
        {
            helperInOrder(raiz);
        }
        //método recursivo para realizar el recorrido inorden
        public void helperInOrder(NodeTree nodo)
        {
            if (nodo == null)
                return;
            helperInOrder(nodo.leftNode);
            //recorrer subárbol left				
            Console.WriteLine(nodo.data + " ");
            //mostrar data del nodo
            helperInOrder(nodo.rightNode);
            //recorrer subárbol right
        }
        //empezar recorrido postorden
        public void postOrder()
        {
            helperPostOrder(raiz);
        }
        //método recursivo para realizar el recorrido postorden
        public void helperPostOrder(NodeTree nodo)
        {
            if (nodo == null)
                return;
            helperPostOrder(nodo.leftNode);
            //recorrer subárbol left				
            helperPostOrder(nodo.rightNode);
            //recorrer subárbol right
            Console.WriteLine(nodo.data + " ");
            //mostrar data del nodo
        }
    }
}
