using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ArbolRecubridorv2._0.Class
{
    class AnalizerGraph
    {
        /// <summary>
        /// Crea el conjunto de objetos Arista y Nodo a partir de la cadena representación
        /// </summary>
        /// <param name="cadenaGrafo">La cadena representación del grafo a resolver</param>
        /// <returns></returns>
        public static List<Rand> crearGrafo(String cadenaGrafo)
        {
            List<Node> nodos;
            List<Rand> aristas;
            StringReader reader;
            int V, E;
            int idNodoA, idNodoB, peso;

            reader = new StringReader(cadenaGrafo);


            V = Int32.Parse(reader.ReadLine());
            E = Int32.Parse(reader.ReadLine());

            nodos = new List<Node>();
            for (int i = 0; i < V; i++)
            {
                nodos.Add(new Node(i + 1));
            }

            aristas = new List<Rand>();
            for (int i = 0; i < E; i++)
            {
                String[] lineaSegmentada = reader.ReadLine().Split();
                idNodoA = Int32.Parse(lineaSegmentada[0]);
                idNodoB = Int32.Parse(lineaSegmentada[1]);
                peso = Int32.Parse(lineaSegmentada[2]);

                aristas.Add(new Rand(nodos[idNodoA - 1], nodos[idNodoB - 1], peso));
            }

            return aristas;
        }

        public static String leerArchivo(String ruta)
        {
            return null;
        }
    }
}
