using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.IO;

namespace ArbolRecubridorv2._0
{
    class Files
    {
        string path = null, nodes = null;

        string pathFile = @"..\...\Tmp\pathNode.txt";

        public Files(string path, string nodes)
        {
            this.path = path;
            this.nodes = nodes;
        }

        public Files()
        {
            // TODO: Complete member initialization
        }

        public void Create()
        {
            string[] lines = { path, nodes };
            try 
	        {
                System.IO.File.WriteAllLines(pathFile, lines);
	        }
	        catch (Exception)
	        {
		        throw;
	        };
        }

        public void AddLine(string line)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(line);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Null cuando no se leyo nada, valor si hay lectura</returns>
        public string[] ReadFile(string path)
        {
            if( path == null)
            {
                path = pathFile;
            }    
     
            string[] lines = System.IO.File.ReadAllLines(path);
            System.Console.WriteLine("Contents of WriteLines2.txt = ");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }      
   
            return lines;
        }
    }
}
