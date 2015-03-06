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
            //obtener la ruta del archivo con los nodos y pesos.
            string[] chain = pathNode.ReadFile(null);
            string pathFile = chain[0];

            //Leer y llenar
            //
            //Files infoGraph = new Files();
            //string[] infoG = infoGraph.ReadFile(pathFile);

            Graph grafo = new Graph();
            Node[] nodos = new Node[50];
            Rand[] aristas = new Rand[50];

            string[] lines = System.IO.File.ReadAllLines(pathFile);
            System.Console.WriteLine("Contents of WriteLines2.txt = ");

            int i = 0;
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
                                
                ///
                string nodeA = line.Substring(0, line.IndexOf("|"));
                int intNodeA = Convert.ToInt16(nodeA);
                int longNa = nodeA.Length + 1; // 1 del espacio
                Console.WriteLine("Nodo a " + nodeA);

                string nodeB = line.Substring(longNa, line.Substring(longNa).IndexOf("|"));
                int intNodeB = Convert.ToInt16(nodeB);
                int longNab = nodeB.Length + longNa + 1;
                Console.WriteLine("Nodo b " + nodeB);

                int cost = Convert.ToInt16(line.Substring(longNab));
                Console.WriteLine("Costo " + cost);

                //Llenar arreglo de nodos 
                nodos[intNodeA] = new Node(intNodeA);
                nodos[intNodeB] = new Node(intNodeB);
                ///
                aristas[i] = new Rand(nodos[intNodeA], nodos[intNodeB], cost);
                i++;
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

            String cadGraph = lines.ToString();
            
            grafo.Aristas = AnalizerGraph.crearGrafo(cadGraph);

            grafo = Prim.obtenerMSPPrim(grafo);

            foreach (Rand arista in grafo.Aristas)
            {
                Console.WriteLine(arista.toString());
            } 


            
        }

        private void pnlPrim_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = pnlPrim.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(50, 100, 150, 150);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);


        }
    }
}
