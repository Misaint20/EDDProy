using System;
using System.Collections.Generic;
using System.Text;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        private NodoBinario Raiz; // Nodo raíz del árbol
        public string strArbol { get; set; } // Representación del árbol en forma de cadena
        public string strRecorrido { get; set; } // Representación del recorrido del árbol en forma de cadena

        public ArbolBusqueda()
        {
            Raiz = null; // Inicializa la raíz como nula
            strArbol = string.Empty; // Inicializa la representación del árbol como vacía
            strRecorrido = string.Empty; // Inicializa la representación del recorrido como vacía
        }

        // Verifica si el árbol está vacío
        public bool EstaVacio() => Raiz == null;

        // Devuelve el nodo raíz del árbol
        public NodoBinario RegresaRaiz() => Raiz;

        // Inserta un nuevo nodo en el árbol
        public void InsertaNodo(int dato, ref NodoBinario nodo)
        {
            // Si el nodo actual es nulo, crea un nuevo nodo
            if (nodo == null)
            {
                nodo = new NodoBinario(dato);
                if (Raiz == null)
                    Raiz = nodo; // Si es el primer nodo, lo establece como raíz
            }
            // Si el dato es menor, se inserta en el subárbol izquierdo
            else if (dato < nodo.Dato)
                InsertaNodo(dato, ref nodo.Izq);
            // Si el dato es mayor, se inserta en el subárbol derecho
            else if (dato > nodo.Dato)
                InsertaNodo(dato, ref nodo.Der);
        }

        // Muestra el árbol de forma horizontal
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna

            // Llama recursivamente para mostrar el subárbol derecho
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            // Agrega el nodo actual a la representación del árbol
            strArbol += new string(' ', nivel * 6) + nodo.Dato.ToString() + Environment.NewLine;
            // Llama recursivamente para mostrar el subárbol izquierdo
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        // Genera una representación en formato DOT del árbol
        public string ToDot(NodoBinario nodo)
        {
            var sb = new StringBuilder(); // StringBuilder para construir la cadena
            if (nodo.Izq != null)
            {
                // Agrega la relación entre el nodo y su hijo izquierdo
                sb.AppendFormat("{0}->{1} [side=L] {2}", nodo.Dato, nodo.Izq.Dato, Environment.NewLine);
                sb.Append(ToDot(nodo.Izq)); // Llama recursivamente para el hijo izquierdo
            }
            if (nodo.Der != null)
            {
                // Agrega la relación entre el nodo y su hijo derecho
                sb.AppendFormat("{0}->{1} [side=R] {2}", nodo.Dato, nodo.Der.Dato, Environment.NewLine);
                sb.Append(ToDot(nodo.Der)); // Llama recursivamente para el hijo derecho
            }
            return sb.ToString(); // Devuelve la representación en formato DOT
        }

        // Recorrido en preorden
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna
            strRecorrido += nodo.Dato + ", "; // Agrega el dato del nodo actual
            PreOrden(nodo.Izq); // Llama recursivamente para el subárbol izquierdo
            PreOrden(nodo.Der); // Llama recursivamente para el subárbol derecho
        }

        // Recorrido en inorden
        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna
            InOrden(nodo.Izq); // Llama recursivamente para el subárbol izquierdo
            strRecorrido += nodo.Dato + ", "; // Agrega el dato del nodo actual
            InOrden(nodo.Der); // Llama recursivamente para el subárbol derecho
        }

        // Recorrido en postorden
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna
            PostOrden(nodo.Izq); // Llama recursivamente para el subárbol izquierdo
            PostOrden(nodo.Der); // Llama recursivamente para el subárbol derecho
            strRecorrido += nodo.Dato + ", "; // Agrega el dato del nodo actual
        }

        // Busca un nodo con un dato específico
        public bool BuscarNodo(int dato, NodoBinario nodo)
        {
            if (nodo == null) // Si el nodo es nulo, no se encontró
                return false;
            if (dato == nodo.Dato) // Si se encuentra el dato
                return true;
            // Busca en el subárbol izquierdo o derecho según el valor del dato
            return dato < nodo.Dato ? BuscarNodo(dato, nodo.Izq) : BuscarNodo(dato, nodo.Der);
        }

        // Poda el árbol, eliminando todos los nodos
        public void PodarArbol()
        {
            PodarNodo(ref Raiz); // Llama al método para podar desde la raíz
            Raiz = null; // Establece la raíz como nula
            strArbol = string.Empty; // Limpia la representación del árbol
            strRecorrido = string.Empty; // Limpia la representación del recorrido
        }

        // Método recursivo para podar un nodo
        private void PodarNodo(ref NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna

            // Podar subárboles
            PodarNodo(ref nodo.Izq);
            PodarNodo(ref nodo.Der);

            // Eliminar el nodo actual
            nodo.Izq = null;
            nodo.Der = null;
            nodo = null; // Establece el nodo como nulo
        }

        // Elimina un nodo con un dato específico
        public bool EliminarNodo(int dato)
        {
            NodoBinario padre = null; // Nodo padre del nodo a eliminar
            NodoBinario actual = Raiz; // Nodo actual que se está buscando
            bool esHijoIzquierdo = false; // Indica si el nodo a eliminar es hijo izquierdo

            // Si el árbol está vacío
            if (actual == null) return false;

            // Buscar el nodo
            while (actual != null && actual.Dato != dato)
            {
                padre = actual; // Guarda el nodo padre
                if (dato < actual.Dato)
                {
                    actual = actual.Izq; // Mueve al subárbol izquierdo
                    esHijoIzquierdo = true; // Marca como hijo izquierdo
                }
                else
                {
                    actual = actual.Der; // Mueve al subárbol derecho
                    esHijoIzquierdo = false; // Marca como hijo derecho
                }
            }

            // Si no se encontró el nodo
            if (actual == null) return false;

            // Caso 1: Nodo es hoja (no tiene hijos)
            if (actual.Izq == null && actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = null; // Si es la raíz, establece como nula
                else if (esHijoIzquierdo)
                    padre.Izq = null; // Elimina el hijo izquierdo
                else
                    padre.Der = null; // Elimina el hijo derecho
            }
            // Caso 2: Nodo tiene un solo hijo
            else if (actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Izq; // Reemplaza la raíz con su hijo izquierdo
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Izq; // Reemplaza el hijo izquierdo
                else
                    padre.Der = actual.Izq; // Reemplaza el hijo derecho
            }
            else if (actual.Izq == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Der; // Reemplaza la raíz con su hijo derecho
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Der; // Reemplaza el hijo izquierdo
                else
                    padre.Der = actual.Der; // Reemplaza el hijo derecho
            }
            // Caso 3: Nodo tiene dos hijos
            else
            {
                NodoBinario sucesor = ObtenerSucesor(actual); // Obtiene el sucesor
                if (actual == Raiz)
                    Raiz = sucesor; // Reemplaza la raíz con el sucesor
                else if (esHijoIzquierdo)
                    padre.Izq = sucesor; // Reemplaza el hijo izquierdo
                else
                    padre.Der = sucesor; // Reemplaza el hijo derecho

                sucesor.Izq = actual.Izq; // Conecta el hijo izquierdo del nodo a eliminar al sucesor
            }

            return true; // Indica que la eliminación fue exitosa
        }

        // Obtiene el sucesor en el árbol
        private NodoBinario ObtenerSucesor(NodoBinario nodoEliminar)
        {
            NodoBinario sucesorPadre = nodoEliminar; // Guarda el padre del sucesor
            NodoBinario sucesor = nodoEliminar; // Inicializa el sucesor
            NodoBinario actual = nodoEliminar.Der; // Comienza en el subárbol derecho

            while (actual != null)
            {
                sucesorPadre = sucesor; // Actualiza el padre del sucesor
                sucesor = actual; // Actualiza el sucesor
                actual = actual.Izq; // Mueve al subárbol izquierdo
            }

            // Si el sucesor no es el hijo derecho del nodo a eliminar
            if (sucesor != nodoEliminar.Der)
            {
                sucesorPadre.Izq = sucesor.Der; // Conecta el hijo derecho del sucesor al padre del sucesor
                sucesor.Der = nodoEliminar.Der; // Conecta el hijo derecho del nodo a eliminar al sucesor
            }

            return sucesor; // Devuelve el sucesor
        }

        // Realiza un recorrido por niveles del árbol
        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, retorna

            Queue<NodoBinario> cola = new Queue<NodoBinario>(); // Cola para el recorrido por niveles
            cola.Enqueue(nodo); // Encola el nodo raíz

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue(); // Desencola el nodo actual
                strRecorrido += actual.Dato + ", "; // Agrega el dato del nodo actual

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq); // Encola el hijo izquierdo
                if (actual.Der != null)
                    cola.Enqueue(actual.Der); // Encola el hijo derecho
            }
        }

        // Obtener altura del árbol
        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz); // Llama al método para calcular la altura desde la raíz
        }

        private int CalcularAltura(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, retorna 0
            return 1 + Math.Max(CalcularAltura(nodo.Izq), CalcularAltura(nodo.Der)); // Calcula la altura
        }

        // Cantidad de hojas
        public int ContarHojas()
        {
            return ContarHojasRecursivo(Raiz); // Llama al método para contar hojas desde la raíz
        }

        private int ContarHojasRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, retorna 0
            if (nodo.Izq == null && nodo.Der == null) return 1; // Si es una hoja, cuenta 1
            return ContarHojasRecursivo(nodo.Izq) + ContarHojasRecursivo(nodo.Der); // Suma las hojas de ambos subárboles
        }

        // Cantidad total de nodos
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz); // Llama al método para contar nodos desde la raíz
        }

        private int ContarNodosRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, retorna 0
            return 1 + ContarNodosRecursivo(nodo.Izq) + ContarNodosRecursivo(nodo.Der); // Cuenta el nodo actual y los de ambos subárboles
        }

        // Verificar si es árbol completo
        public bool EsArbolCompleto()
        {
            return EsArbolCompletoRecursivo(Raiz, 0, ContarNodos()); // Llama al método para verificar si es completo
        }

        private bool EsArbolCompletoRecursivo(NodoBinario nodo, int index, int numeroNodos)
        {
            if (nodo == null) return true; // Si el nodo es nulo, es completo
            if (index >= numeroNodos) return false; // Si el índice es mayor o igual al número de nodos, no es completo
            return EsArbolCompletoRecursivo(nodo.Izq, 2 * index + 1, numeroNodos) &&
                   EsArbolCompletoRecursivo(nodo.Der, 2 * index + 2, numeroNodos); // Verifica recursivamente ambos subárboles
        }

        // Verificar si es árbol lleno
        public bool EsArbolLleno()
        {
            return EsArbolLlenoRecursivo(Raiz); // Llama al método para verificar si es lleno
        }

        private bool EsArbolLlenoRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return true; // Si el nodo es nulo, es lleno
            if (nodo.Izq == null && nodo.Der == null) return true; // Si es una hoja, es lleno
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolLlenoRecursivo(nodo.Izq) && EsArbolLlenoRecursivo(nodo.Der); // Verifica recursivamente ambos subárboles
            return false; // Si uno de los hijos es nulo, no es lleno
        }
    }
}