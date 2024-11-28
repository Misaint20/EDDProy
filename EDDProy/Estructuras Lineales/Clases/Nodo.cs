using System;

namespace EDDemo.Estructuras_lineales.Clases
{
    // Clase que representa un nodo en una estructura de datos
    internal class Nodo
    {
        // Propiedad que almacena el dato del nodo
        public object Dato { get; set; }

        // Propiedad que referencia al siguiente nodo en la estructura
        public Nodo Sig { get; set; }

        // Constructor de la clase Nodo
        public Nodo(object dato)
        {
            // Inicializa el dato del nodo
            Dato = dato;
            // Inicializa la referencia al siguiente nodo como null
            Sig = null;
        }
    }
}