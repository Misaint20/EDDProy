using System;

namespace EDDemo.Estructuras_lineales.Clases
{
    // Clase que representa una cola
    internal class Cola
    {
        private Nodo top; // Nodo que representa el frente de la cola
        private Nodo fin; // Nodo que representa el final de la cola

        // Método para insertar un elemento en la cola
        public void Enqueue(object dato)
        {
            // Crea un nuevo nodo con el dato proporcionado
            Nodo nuevoNodo = new Nodo(dato);

            // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
            if (EstaVacia())
            {
                top = nuevoNodo;
                fin = nuevoNodo;
            }
            else
            {
                // Si no está vacía, añade el nuevo nodo al final y actualiza la referencia final
                fin.Sig = nuevoNodo;
                fin = nuevoNodo;
            }
        }

        // Método para eliminar un elemento de la cola
        public void Dequeue()
        {
            // Verifica si la cola no está vacía
            if (!EstaVacia())
            {
                // Mueve el frente a la siguiente posición
                top = top.Sig;

                // Si después de eliminar el nodo, la cola queda vacía, también actualiza el final
                if (top == null)
                {
                    fin = null;
                }
            }
        }

        // Método para verificar si la cola está vacía
        public bool EstaVacia()
        {
            // Devuelve true si el frente es null, indicando que la cola está vacía
            return top == null;
        }

        // Método para buscar un elemento en la cola
        public int Buscar(string datoBuscado)
        {
            Nodo actual = top; // Comienza desde el frente de la cola
            int posicion = 0; // Inicializa la posición en 0

            while (actual != null) // Recorre la cola hasta que no haya más nodos
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

        // Método para obtener el dato en el frente de la cola
        public Nodo Top()
        {
            // Devuelve el dato del nodo en el frente de la cola si no está vacía
            return EstaVacia() ? null : top;
        }
    }
}