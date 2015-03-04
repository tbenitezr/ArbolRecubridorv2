using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ArbolRecubridorv2._0.Class;

namespace ArbolRecubridorv2._0
{
    public partial class FrmGraph : Form
    {
        public FrmGraph()
        {
            InitializeComponent();
        }

        private void Dos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Files pathNode = new Files(); 
            //obtener path
            string[] chain = pathNode.ReadFile(null);

            string pathFile = chain[0];
            int numNodes = Convert.ToInt16(chain[1]);
            int numRand = Convert.ToInt16(chain[1]);


            //Leer y llenar
            //
            Files infoGraph = new Files();
            string[] infoG = infoGraph.ReadFile(pathFile);

            
            

            Graph grafo = new Graph();
            Node[] nodos = new Node[3];
            Rand[] aristas = new Rand[3];

            for (int i = 0; i < numNodes; i++)
            {
                nodos[i] = new Node(i);
            }

            for (int i = 0; i < 3; i++)
            {
                Node nodeA = ;
                Node nodeB = ;
                int cost =;
                aristas[i] = new Rand(nodeA, nodeB, cost);
            }

            foreach (Rand arista in grafo.Aristas)
            {
                Console.WriteLine(arista.toString());
            }

            grafo.ordenarAristas();

            Console.WriteLine("");
            foreach (Rand arista in grafo.Aristas)
            {
                Console.WriteLine(arista.toString());
            }

            Console.WriteLine("\nSegunda prueba");
            Graph grafo2 = new Graph();
            String cadenaGrafo = "3\n3\n1 2 1\n2 3 1\n3 1 2\n";
            grafo2.Aristas = AnalizerGraph.crearGrafo(cadenaGrafo);

            grafo2 = Prim.obtenerMSPPrim(grafo2);

            foreach (Rand arista in grafo2.Aristas)
            {
                Console.WriteLine(arista.toString());
            }
        }
    }
}
