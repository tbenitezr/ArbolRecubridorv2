using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolRecubridorv2._0.Class
{
    class Queue
    {
        // La cola como tal es privada, y no puede ser modificada si no es 
        // por las operaciones definidas push y pop
        private LinkedList<Object> cola;
        // El tamaño actual de la cola
        public int Count
        {
            get { return cola.Count; }
        }
        public Queue()
        {
            this.cola = new LinkedList<Object>();
        }
        /// <summary>
        /// Operación para insertar un elemento al inicio la cola
        /// </summary>
        /// <param name="dato">El objeto a insertar</param>
        public void push(Object dato)
        {
            cola.AddFirst(dato);
        }
        /// <summary>
        /// Operación para sacar el último elemento de la cola
        /// </summary>
        /// <returns>El último elemento de la cola</returns>
        public Object pop()
        {
            Object dato = cola.Last.Value;

            try
            {
                cola.Remove(dato);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return dato;
        }
    }
}
