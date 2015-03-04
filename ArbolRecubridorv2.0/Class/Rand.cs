using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    class Rand: IComparable<Rand>
    {
        // Primer nodo
        private Node nodoA;

        public Node NodoA
        {
            get { return nodoA; }
            set { nodoA = value; }
        }

        // Segundo nodo
        private Node nodoB;

        public Node NodoB
        {
            get { return nodoB; }
            set { nodoB = value; }
        }

        // Peso de esta arista
        private int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Rand(Node nodoA, Node nodoB, int peso)
        {
            this.NodoA = nodoA;
            this.NodoB = nodoB;
            this.Peso = peso;
        }
        /// <summary>
        /// Implementa el método CompareTo de la interfaz IComparable para poder
        /// ordenar las aristas según el peso.
        /// </summary>
        /// <param name="otra">La arista con la que se compara</param>
        /// <returns>1 si esta arista tiene peso mayor, -1 si tiene peso menor
        /// 0 si son iguales</returns>
        public int CompareTo(Rand otra)
        {
            if (this.Peso > otra.Peso)
            {
                return 1;
            }
            else if (this.Peso < otra.Peso)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Crea una representación en String de la arista
        /// </summary>
        /// <returns></returns>
        public String toString()
        {
            return String.Format("[nodoA:{0:D}, nodoB:{1:D}, peso:{2:D}]", this.NodoA.Id, this.NodoB.Id, this.Peso);
        }
    }
}
