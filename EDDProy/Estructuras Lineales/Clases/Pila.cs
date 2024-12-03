using System;
using System.Text;

namespace EDDemo.Estructuras_lineales.Clases
{
    // Clase que representa una pila
    internal class Pila
    {
        // Nodo que representa el tope de la pila
        private Nodo top;

        // Método para obtener el nodo que está en la parte superior de la pila
        public Nodo Top()
        {
            return top; // Devuelve el nodo en la parte superior de la pila
        }

        // Método para insertar un elemento en la pila
        public void Push(object dato)
        {
            // Crea un nuevo nodo con el dato proporcionado
            Nodo nuevoNodo = new Nodo(dato)
            {
                // Establece el siguiente nodo como el nodo que estaba en la parte superior
                Sig = top
            };
            // Actualiza el tope de la pila al nuevo nodo
            top = nuevoNodo;
        }

        // Método para eliminar un elemento de la pila
        public void Pop()
        {
            // Verifica si la pila no está vacía
            if (top != null)
            {
                // Actualiza el tope de la pila al siguiente nodo
                top = top.Sig;
            }
        }

        // Método para verificar si la pila está vacía
        public bool EstaVacia()
        {
            // Devuelve true si el tope es null, indicando que la pila está vacía
            return top == null;
        }

        // Método para buscar un elemento en la pila
        public int Buscar(string datoBuscado)
        {
            Nodo actual = top; // Comienza desde el tope de la pila
            int posicion = 0; // Inicializa la posición en 0

            while (actual != null) // Recorre la pila hasta que no haya más nodos
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
    }
}