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
            System.Console.WriteLine("Contents of txt = ");

            int i = 0;
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
                                
                ///
                string nodeA = line.Substring(0, line.IndexOf(" "));
                int intNodeA = Convert.ToInt16(nodeA);
                int longNa = nodeA.Length + 1; // 1 del espacio
                Console.WriteLine("Nodo a " + nodeA);

                string nodeB = line.Substring(longNa, line.Substring(longNa).IndexOf(" "));
                int intNodeB = Convert.ToInt16(nodeB);
                int longNab = nodeB.Length + longNa + 1;
                Console.WriteLine("Nodo b " + nodeB);

                int cost = Convert.ToInt16(line.Substring(longNab));
                Console.WriteLine("Costo " + cost);

                //Llenar arreglo de nodos 
                nodos[intNodeA] = new Node(intNodeA);
                nodos[intNodeB] = new Node(intNodeB);
                ///
                //
                aristas[i] = new Rand(nodos[intNodeA], nodos[intNodeB], cost);
                i++;

            }

            Console.WriteLine("Hola  \t");
            /*foreach (Rand arista in grafo.Aristas)
            {
                Console.WriteLine(arista.toString());
            }

            grafo.ordenarAristas();

            Console.WriteLine("");*/ //No imprime nada

           

            Graph grafo2 = new Graph();



            String cadGraph = lines.ToString();
            
            //grafo.Aristas = AnalizerGraph.crearGrafo(cadGraph);

            //grafo = Prim.obtenerMSPPrim(grafo);

            foreach (Rand arista in grafo.Aristas)
            {
                Console.WriteLine(arista.toString());
            } 
                       
        }

        private void pnlPrim_Paint(object sender, PaintEventArgs e)
        {
            int numNodes = 8;
            int tamCir = 7;

            int cDiam = pnlPrim.Height;
            double cRadius = cDiam / 2;
            double cRadiusI = (cDiam - 2 * tamCir) / 2; //Radio del círculo interior del panel

            double grades = 360 / numNodes;

            ///
            Point result = new Point(0, 0);
            Point centerPoint = new Point(Convert.ToInt16(cRadius - tamCir), Convert.ToInt16(cRadius - tamCir));
            double angle = grades * Math.PI / 180; //Math.PI / (180 / numNodes); // *Math.PI / 180; //between 0 and 2 * PI, angle is in radians
            double oangle = angle; //Angulo original.

            int[] result2x = new int[numNodes];
            int[] result2y = new int[numNodes];

            for (int i = 0; i < numNodes; i++)
            {

                result.Y = (int)Math.Round(centerPoint.Y + cRadiusI * Math.Sin(angle));
                result.X = (int)Math.Round(centerPoint.X + cRadiusI * Math.Cos(angle));
                System.Drawing.Graphics graphics = pnlPrim.CreateGraphics();
                graphics.DrawEllipse(System.Drawing.Pens.Black, result.X, result.Y, 7, 7);
                angle = oangle * (i + 2);

                result2x[i] = result.X;
                result2y[i] = result.Y;

            }
            
            for (int i = 0; i < numNodes; i++) 
            {
                System.Drawing.Graphics graphicsObj;
                graphicsObj = pnlPrim.CreateGraphics();

                Pen myPen = new Pen(System.Drawing.Color.Red, 5);

                graphicsObj.DrawLine(myPen, result2x[i], result2y[i], result2x[i+1], result2y[i+1]);
            }

        }
    }
}
