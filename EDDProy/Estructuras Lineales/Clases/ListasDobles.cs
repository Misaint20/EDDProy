using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_lineales.Clases
{
    internal class ListasDobles
    {
        private Nodo cabeza; // Nodo que representa el inicio de la lista
        private Nodo cola;   // Nodo que representa el final de la lista

        // Método para insertar un nuevo Nodo
        public void Insertar(object dato, int posicion)
        {
            if (posicion < 0) MessageBox.Show("La posición no puede ser negativa.");

            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo

            // Si la posición es 0, agrega al inicio
            if (posicion == 0)
            {
                nuevoNodo.Sig = cabeza; // El nuevo nodo apunta a la cabeza actual
                if (cabeza != null)
                {
                    cabeza.Ant = nuevoNodo; // El nodo anterior de la cabeza ahora apunta al nuevo nodo
                }
                cabeza = nuevoNodo; // La cabeza ahora es el nuevo nodo
                if (cola == null) // Si la lista estaba vacía, la cola también es el nuevo nodo
                {
                    cola = nuevoNodo;
                }
                return;
            }

            Nodo actual = cabeza; // Comienza desde la cabeza
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Sig;
                contador++;
            }

            // Si la posición es mayor que el número de nodos, agrega al final
            if (actual == null)
            {
                // Si la lista está vacía, se convierte en la cabeza
                if (cabeza == null)
                {
                    cabeza = nuevoNodo;
                    cola = nuevoNodo; // La cola también será el nuevo nodo
                }
                else
                {
                    cola.Sig = nuevoNodo; // El nodo anterior a la cola apunta al nuevo nodo
                    nuevoNodo.Ant = cola; // El nuevo nodo apunta hacia atrás a la cola
                    cola = nuevoNodo; // Actualiza la cola
                }
            }
            else
            {
                nuevoNodo.Sig = actual.Sig; // El nuevo nodo apunta al siguiente nodo
                nuevoNodo.Ant = actual; // El nuevo nodo apunta hacia atrás al nodo actual
                if (actual.Sig != null)
                {
                    actual.Sig.Ant = nuevoNodo; // El siguiente nodo apunta hacia atrás al nuevo nodo
                }
                actual.Sig = nuevoNodo; // El nodo actual apunta al nuevo nodo
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
                cabeza = cabeza.Sig; // Mueve la cabeza al siguiente nodo
                if (cabeza != null)
                {
                    cabeza.Ant = null; // La nueva cabeza no tiene nodo anterior
                }
                else
                {
                    cola = null; // Si la lista queda vacía, la cola también es null
                }
                return;
            }

            Nodo actual = cabeza; // Comienza desde la cabeza
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (actual != null && contador < posicion)
            {
                actual = actual.Sig;
                contador++;
            }

            // Si el nodo a eliminar no existe, no se realiza ninguna eliminación
            if (actual == null) return;

            // Si el nodo a eliminar es la cola
            if (actual.Sig == null)
            {
                cola = actual.Ant; // Actualiza la cola al nodo anterior
                if (cola != null)
                {
                    cola.Sig = null; // El nuevo nodo cola no tiene siguiente
                }
            }
            else
            {
                actual.Sig.Ant = actual.Ant; // El siguiente nodo apunta hacia atrás al nodo anterior
            }

            if (actual.Ant != null)
            {
                actual.Ant.Sig = actual.Sig; // El nodo anterior apunta al siguiente nodo
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

            while (actual != null) // Recorre la lista hasta que no haya más nodos
            {
                if (actual.Dato.Equals(datoBuscado)) // Compara el dato del nodo actual con el dato buscado
                {
                    return posicion; // Devuelve la posición si se encuentra el dato
                }
                actual = actual.Sig; // Avanza al siguiente nodo
                posicion++; // Incrementa la posición
            }

            return -1; // Devuelve -1 si no se encuentra el dato
        }

        // Método para obtener el primer nodo de la lista
        public Nodo Cabeza()
        {
            return cabeza; // Devuelve la cabeza de la lista
        }

        public Nodo Cola()
        {
            return cola;
        }
    }
}