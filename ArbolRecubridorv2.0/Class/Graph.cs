using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    class Graph
    {
        #region Atributos
        // Conjunto de nodos en el grafo
        private List<Node> nodos;

        public List<Node> Nodos
        {
            get { return nodos; }
            set { nodos = value; }
        }
        // Conjunto de aristas en el grafo
        private List<Rand> aristas;

        public List<Rand> Aristas
        {
            get { return aristas; }
            set { aristas = value; }
        }

        #endregion 

        /// <summary>
        /// Construye un nuevo grafo vacío
        /// </summary>
        public Graph()
        {
            this.nodos = new List<Node>();
            this.aristas = new List<Rand>();
        }
        /// <summary>
        /// Construye un nuevo grafo a partir de una lista de aristas
        /// </summary>
        /// <param name="aristas">La lista de aristas a partir de la cual se va a generar
        /// el grafo</param>
        public Graph(List<Rand> aristas)
        {
            this.Aristas = aristas;
            this.nodos = new List<Node>();

            foreach (Rand arista in this.Aristas)
            {
                if (!nodos.Contains(arista.NodoA))
                {
                    nodos.Add(arista.NodoA);
                }
                if (!nodos.Contains(arista.NodoB))
                {
                    nodos.Add(arista.NodoB);
                }
            }
        }
        /// <summary>
        /// Añade una arista y ambos nodos al grafo, si es que no están en el
        /// todavía, y actualiza la lista de adyacentes del grafo.
        /// </summary>
        /// <param name="arista">La arista que se va a añadir al grafo</param>
        public void addArista(Rand arista)
        {
            // Añadir a la lista de aristas si no está ahí
            if (!Aristas.Contains(arista))
            {
                Aristas.Add(arista);
            }
            // Añadir ambos nodos de la arista si no están en la lista
            if (!Nodos.Contains(arista.NodoA))
            {
                Nodos.Add(arista.NodoA);
            }
            if (!Nodos.Contains(arista.NodoB))
            {
                Nodos.Add(arista.NodoB);
            }
            // Añadir nodoA a la lista de adyacentes de B y viceversa
            if (!arista.NodoB.Adyacentes.Contains(arista.NodoA))
            {
                arista.NodoB.Adyacentes.Add(arista.NodoA);
            }
            if (!arista.NodoA.Adyacentes.Contains(arista.NodoB))
            {
                arista.NodoA.Adyacentes.Add(arista.NodoB);
            }
        }
        /// <summary>
        /// Ordena las aristas en el grafo por peso en orden ascendente
        /// </summary>
        public void ordenarAristas()
        {
            this.Aristas.Sort();
        }
    }
}
