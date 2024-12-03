using System;

namespace EDDemo.Estructuras_lineales.Clases
{
    internal class ListasCirculares
    {
        private Nodo cabeza; // Nodo que representa el inicio de la lista

        // Método para insertar un nuevo Nodo
        public void Insertar(object dato, int posicion)
        {
            if (posicion < 0) throw new ArgumentOutOfRangeException("La posición no puede ser negativa.");

            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo

            // Si la lista está vacía, el nuevo nodo apunta a sí mismo
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                nuevoNodo.Sig = cabeza; // El nuevo nodo apunta a sí mismo
                return;
            }

            // Si la posición es 0, agrega al inicio
            if (posicion == 0)
            {
                Nodo temp = cabeza;

                // Encuentra el último nodo para que apunte al nuevo nodo
                while (temp.Sig != cabeza)
                {
                    temp = temp.Sig;
                }

                temp.Sig = nuevoNodo; // El último nodo apunta al nuevo nodo
                nuevoNodo.Sig = cabeza; // El nuevo nodo apunta a la cabeza
                cabeza = nuevoNodo; // La cabeza ahora es el nuevo nodo
                return;
            }

            Nodo actual = cabeza;
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (contador < posicion - 1 && actual.Sig != cabeza)
            {
                actual = actual.Sig;
                contador++;
            }

            // Inserta el nuevo nodo
            nuevoNodo.Sig = actual.Sig; // El nuevo nodo apunta al siguiente nodo
            actual.Sig = nuevoNodo; // El nodo actual apunta al nuevo nodo
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
                    return;
                }

                Nodo temp = cabeza;

                // Encuentra el último nodo
                while (temp.Sig != cabeza)
                {
                    temp = temp.Sig;
                }

                temp.Sig = cabeza.Sig; // El último nodo apunta al segundo nodo
                cabeza = cabeza.Sig; // Mueve la cabeza al siguiente nodo
                return;
            }

            Nodo actual = cabeza;
            int contador = 0;

            // Recorre hasta la posición deseada o hasta el final de la lista
            while (contador < posicion - 1 && actual.Sig != cabeza)
            {
                actual = actual.Sig;
                contador++;
            }

            // Si el siguiente nodo es la cabeza, no se realiza ninguna eliminación
            if (actual.Sig == cabeza) return;

            actual.Sig = actual.Sig.Sig; // Salta el nodo a eliminar
        }

        // Método para verificar si la lista está vacía
        public bool EstaVacia()
        {
            return cabeza == null; // Devuelve true si la cabeza es null
        }

        // Método para buscar un elemento en la lista
        public int Buscar(object datoBuscado)
        {
            if (cabeza == null) return -1; // Si la lista está vacía

            Nodo actual = cabeza; // Comienza desde la cabeza
            int posicion = 0; // Inicializa la posición en 0

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
    }
}