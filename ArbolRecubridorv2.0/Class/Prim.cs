using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    class Prim
    {
        public static Graph obtenerMSPPrim(Graph grafo)
        {
            Graph solucion = new Graph();

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
