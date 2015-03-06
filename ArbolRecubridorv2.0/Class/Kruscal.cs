using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    /// <summary>
    /// Debe de seleccionar primero la arista con el menor coste
    /// y así sucesivamente revisando al momento de agregar una arista no se haga un ciclo.
    /// </summary>
    class Kruscal
    {
        #region Atributos
        #endregion

        #region Construcctores
        #endregion

        #region Métodos
        #endregion

        public static Graph obtenerMSPKruscal(Graph grafo)
        {
            Graph solucion = new Graph();

            //Ordena supongo de menor a mayor.
            grafo.Aristas.Sort();

            foreach (Rand arista in grafo.Aristas)
            {
                if (arista.NodoA.GetRaiz() != arista.NodoB.GetRaiz())
                {
                    Node.Unir(arista.NodoA, arista.NodoB);
                    solucion.addArista(arista);
                }
                if (grafo.Nodos.Count == solucion.Nodos.Count)
                {
                    break;
                }
            }

            return solucion;
        }

    }
}
