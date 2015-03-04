using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    class Node
    {
        public Node(int id)
        {
            this.Id = id;
            this.adyacentes = new List<Node>();
            this.explorado = false;
            this.Raiz = this;
        }
        // Lista de nodos adyacentes
        private List<Node> adyacentes;

        internal List<Node> Adyacentes
        {
            get { return adyacentes; }
            set { adyacentes = value; }
        }

        // Estado (explorado/no explorado) para los algortmos de búsqueda
        private bool explorado;

        public bool Explorado
        {
            get { return explorado; }
            set { explorado = value; }
        }

        // Identificador del nodo
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Node Raiz { get; set; }

        public int Rango { get; set; }
        /// <summary>
        /// Obtiene la "raíz" del nodo, o el nodo de mayor rango que está
        /// conectado por una arista actualmente.
        /// </summary>
        /// <returns>El Nodo raíz de este Nodo</returns>
        public Node GetRaiz()
        {
            if (this.Raiz != this)// ¿Soy mi propia raíz?
            {
                this.Raiz = this.Raiz.GetRaiz();// ¿No? Entonces conseguir la raíz de mi padre
            }

            return this.Raiz;
        }

        public static void Unir(Node Raiz1, Node Raiz2)
        {
            if (Raiz2.Rango < Raiz1.Rango) // Comparar Rangos
            {
                Raiz2.Raiz = Raiz1; // El rango mayor es la raíz 
            }
            else // Si no es al revés
            {
                Raiz1.Raiz = Raiz2; // Hacer a Raíz 2 el padre
                if (Raiz1.Rango == Raiz2.Rango) // Si ambos rangos son iguales
                {
                    Raiz2.Rango++; // Increment Raiz2, we need to reach a single Raiz for the whole tree
                }
            }
        }
    }
    
}
