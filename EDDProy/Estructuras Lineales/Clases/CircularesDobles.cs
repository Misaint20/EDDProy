using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_lineales.Clases
{
    internal class CircularesDobles
    {
        private Nodo cabeza; // Nodo que representa el inicio de la lista
        private Nodo cola;   // Nodo que representa el final de la lista

        // Método para insertar un nuevo Nodo
        public void Insertar(object dato, int posicion)
        {
            if (posicion < 0) throw new ArgumentOutOfRangeException("La posición no puede ser negativa.");

            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo

            // Si la lista está vacía
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                cabeza.Sig = cabeza; // El siguiente de la cabeza apunta a sí mismo
                cabeza.Ant = cabeza; // El anterior de la cabeza apunta a sí mismo
                return;
            }

            // Si la posición es 0, agrega al inicio
            if (posicion == 0)
            {
                nuevoNodo.Sig = cabeza; // El nuevo nodo apunta a la cabeza actual
                nuevoNodo.Ant = cola;   // El nuevo nodo apunta hacia atrás a la cola
                cabeza.Ant = nuevoNodo; // La cabeza anterior apunta al nuevo nodo
                cola.Sig = nuevoNodo;   // La cola apunta al nuevo nodo
                cabeza = nuevoNodo;      // La cabeza ahora es el nuevo nodo
                return;
            }

            Nodo actual = cabeza; // Comienza desde la cabeza
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (actual.Sig != cabeza && contador < posicion - 1)
            {
                actual = actual.Sig;
                contador++;
            }

            // Inserta el nuevo nodo
            nuevoNodo.Sig = actual.Sig; // El nuevo nodo apunta al siguiente nodo
            nuevoNodo.Ant = actual;      // El nuevo nodo apunta hacia atrás al nodo actual
            actual.Sig.Ant = nuevoNodo;  // El siguiente nodo apunta hacia atrás al nuevo nodo
            actual.Sig = nuevoNodo;       // El nodo actual apunta al nuevo nodo

            // Si se inserta al final, actualiza la cola
            if (nuevoNodo.Sig == cabeza)
            {
                cola = nuevoNodo; // Actualiza la cola
            }
        }

        // Método para eliminar un elemento en una posición específica
        public void Eliminar(int posicion)
        {
            if (posicion < 0) throw new ArgumentOutOfRangeException("La posición no puede ser negativa.");

            if (cabeza == null) return; // Si la lista está vacía, no hace nada

            // Si el nodo a eliminar es la cabeza
            if (posicion == 0)
            {
                if (cabeza.Sig == cabeza) // Si solo hay un nodo
                {
                    cabeza = null; // La lista queda vacía
                    cola = null; // La cola también queda vacía
                    return;
                }

                cola.Sig = cabeza.Sig; // La cola apunta al siguiente nodo
                cabeza.Sig.Ant = cola;  // El siguiente nodo apunta hacia atrás a la cola
                cabeza = cabeza.Sig;     // Mueve la cabeza al siguiente nodo
                return;
            }

            Nodo actual = cabeza; // Comienza desde la cabeza
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (actual.Sig != cabeza && contador < posicion)
            {
                actual = actual.Sig;
                contador++;
            }

            // Si el nodo a eliminar no existe, no se realiza ninguna eliminación
            if (actual == cabeza) return; // Si se intenta eliminar la cabeza nuevamente

            actual.Ant.Sig = actual.Sig; // El nodo anterior apunta al siguiente nodo
            actual.Sig.Ant = actual.Ant;  // El siguiente nodo apunta hacia atrás al nodo anterior

            // Si se elimina la cola
            if (actual == cola)
            {
                cola = actual.Ant; // Actualiza la cola al nodo anterior
            }
        }

        // Método para verificar si la lista está vacía
        public bool EstaVacia()
        {
            return cabeza == null; // Devuelve true si la cabeza es null
        }

        // Método para buscar un elemento en la lista
        public int Buscar(object datoBuscado)
        {
            Nodo actual = cabeza; // Comienza desde la cabeza
            int posicion = 0; // Inicializa la posición en 0

            if (actual == null) return -1; // Si la lista está vacía, devuelve -1

            do
            {
                if (actual.Dato.Equals(datoBuscado)) // Compara el dato del nodo actual con el dato buscado
                {
                    return posicion; // Devuelve la posición si se encuentra el dato
                }
                actual = actual.Sig; // Avanza al siguiente nodo
                posicion++; // Incrementa la posición
            } while (actual != cabeza); // Continúa hasta volver a la cabeza

            return -1; // Devuelve -1 si no se encuentra el dato
        }

        // Método para obtener el primer nodo de la lista
        public Nodo Cabeza()
        {
            return cabeza; // Devuelve la cabeza de la lista
        }

        public Nodo Cola()
        {
            return cola; // Devuelve la cola de la lista
        }
    }
}