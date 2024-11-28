using System;

namespace EDDemo.Estructuras_lineales.Clases
{
    internal class Listas
    {
        private Nodo cabeza; // Nodo que representa el inicio de la lista

        // Metodo para insertar un nuevo Nodo
        public void Insertar(object dato, int posicion)
        {
            if (posicion < 0) throw new ArgumentOutOfRangeException("La posición no puede ser negativa.");

            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo

            // Si la posición es 0, agrega al inicio
            if (posicion == 0)
            {
                nuevoNodo.Sig = cabeza; // El nuevo nodo apunta a la cabeza actual
                cabeza = nuevoNodo; // La cabeza ahora es el nuevo nodo
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
                }
                else
                {
                    // Recorre hasta el final y agrega el nuevo nodo
                    Nodo temp = cabeza;
                    while (temp.Sig != null)
                    {
                        temp = temp.Sig;
                    }
                    temp.Sig = nuevoNodo;
                }
            }
            else
            {
                nuevoNodo.Sig = actual.Sig; // El nuevo nodo apunta al siguiente nodo
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

            // Si la posición es mayor que el número de nodos, no se realiza ninguna eliminación
            if (actual == null || actual.Sig == null)
            {
                // Eliminar el último nodo
                Nodo temp = cabeza;
                if (temp == null) return; // Si la lista está vacía, no hace nada

                // Si hay solo un nodo
                if (temp.Sig == null)
                {
                    cabeza = null; // La lista queda vacía
                    return;
                }

                // Recorre hasta el penúltimo nodo
                while (temp.Sig.Sig != null)
                {
                    temp = temp.Sig;
                }
                temp.Sig = null; // Elimina el último nodo
            }
            else
            {
                actual.Sig = actual.Sig.Sig; // Salta el nodo a eliminar
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
    }
}