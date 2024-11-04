using System;
using System.Collections.Generic;
using System.Text;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        private NodoBinario Raiz;
        public string strArbol { get; set; }
        public string strRecorrido { get; set; }

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = string.Empty;
            strRecorrido = string.Empty;
        }

        public bool EstaVacio() => Raiz == null;

        public NodoBinario RegresaRaiz() => Raiz;

        public void InsertaNodo(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
            {
                nodo = new NodoBinario(dato);
                if (Raiz == null)
                    Raiz = nodo;
            }
            else if (dato < nodo.Dato)
                InsertaNodo(dato, ref nodo.Izq);
            else if (dato > nodo.Dato)
                InsertaNodo(dato, ref nodo.Der);
        }

        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null) return;

            MuestraArbolAcostado(nivel + 1, nodo.Der);
            strArbol += new string(' ', nivel * 6) + nodo.Dato.ToString() + Environment.NewLine;
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public string ToDot(NodoBinario nodo)
        {
            var sb = new StringBuilder();
            if (nodo.Izq != null)
            {
                sb.AppendFormat("{0}->{1} [side=L] {2}", nodo.Dato, nodo.Izq.Dato, Environment.NewLine);
                sb.Append(ToDot(nodo.Izq));
            }
            if (nodo.Der != null)
            {
                sb.AppendFormat("{0}->{1} [side=R] {2}", nodo.Dato, nodo.Der.Dato, Environment.NewLine);
                sb.Append(ToDot(nodo.Der));
            }
            return sb.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null) return;
            strRecorrido += nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null) return;
            InOrden(nodo.Izq);
            strRecorrido += nodo.Dato + ", ";
            InOrden(nodo.Der);
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null) return;
            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido += nodo.Dato + ", ";
        }

        public bool BuscarNodo(int dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;
            if (dato == nodo.Dato)
                return true;
            return dato < nodo.Dato ? BuscarNodo(dato, nodo.Izq) : BuscarNodo(dato, nodo.Der);
        }

        public void PodarArbol()
        {
            PodarNodo(ref Raiz);
            Raiz = null;
            strArbol = string.Empty;
            strRecorrido = string.Empty;
        }

        private void PodarNodo(ref NodoBinario nodo)
        {
            if (nodo == null) return;

            // Podar subárboles
            PodarNodo(ref nodo.Izq);
            PodarNodo(ref nodo.Der);

            // Eliminar el nodo actual
            nodo.Izq = null;
            nodo.Der = null;
            nodo = null;
        }

        public bool EliminarNodo(int dato)
        {
            NodoBinario padre = null;
            NodoBinario actual = Raiz;
            bool esHijoIzquierdo = false;

            // Si el árbol está vacío
            if (actual == null) return false;

            // Buscar el nodo
            while (actual != null && actual.Dato != dato)
            {
                padre = actual;
                if (dato < actual.Dato)
                {
                    actual = actual.Izq;
                    esHijoIzquierdo = true;
                }
                else
                {
                    actual = actual.Der;
                    esHijoIzquierdo = false;
                }
            }

            // Si no se encontró el nodo
            if (actual == null) return false;

            // Caso 1: Nodo es hoja (no tiene hijos)
            if (actual.Izq == null && actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = null;
                else if (esHijoIzquierdo)
                    padre.Izq = null;
                else
                    padre.Der = null;
            }
            // Caso 2: Nodo tiene un solo hijo
            else if (actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Izq;
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Izq;
                else
                    padre.Der = actual.Izq;
            }
            else if (actual.Izq == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Der;
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Der;
                else
                    padre.Der = actual.Der;
            }
            // Caso 3: Nodo tiene dos hijos
            else
            {
                NodoBinario sucesor = ObtenerSucesor(actual);
                if (actual == Raiz)
                    Raiz = sucesor;
                else if (esHijoIzquierdo)
                    padre.Izq = sucesor;
                else
                    padre.Der = sucesor;

                sucesor.Izq = actual.Izq;
            }

            return true;
        }

        private NodoBinario ObtenerSucesor(NodoBinario nodoEliminar)
        {
            NodoBinario sucesorPadre = nodoEliminar;
            NodoBinario sucesor = nodoEliminar;
            NodoBinario actual = nodoEliminar.Der;

            while (actual != null)
            {
                sucesorPadre = sucesor;
                sucesor = actual;
                actual = actual.Izq;
            }

            if (sucesor != nodoEliminar.Der)
            {
                sucesorPadre.Izq = sucesor.Der;
                sucesor.Der = nodoEliminar.Der;
            }

            return sucesor;
        }

        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null) return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                strRecorrido += actual.Dato + ", ";

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
        }

        // Obtener altura del árbol
        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz);
        }

        private int CalcularAltura(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            return 1 + Math.Max(CalcularAltura(nodo.Izq), CalcularAltura(nodo.Der));
        }

        // Cantidad de hojas
        public int ContarHojas()
        {
            return ContarHojasRecursivo(Raiz);
        }

        private int ContarHojasRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            if (nodo.Izq == null && nodo.Der == null) return 1;
            return ContarHojasRecursivo(nodo.Izq) + ContarHojasRecursivo(nodo.Der);
        }

        // Cantidad total de nodos
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz);
        }

        private int ContarNodosRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            return 1 + ContarNodosRecursivo(nodo.Izq) + ContarNodosRecursivo(nodo.Der);
        }

        // Verificar si es árbol completo
        public bool EsArbolCompleto()
        {
            return EsArbolCompletoRecursivo(Raiz, 0, ContarNodos());
        }

        private bool EsArbolCompletoRecursivo(NodoBinario nodo, int index, int numeroNodos)
        {
            if (nodo == null) return true;
            if (index >= numeroNodos) return false;
            return EsArbolCompletoRecursivo(nodo.Izq, 2 * index + 1, numeroNodos) &&
                   EsArbolCompletoRecursivo(nodo.Der, 2 * index + 2, numeroNodos);
        }

        // Verificar si es árbol lleno
        public bool EsArbolLleno()
        {
            return EsArbolLlenoRecursivo(Raiz);
        }

        private bool EsArbolLlenoRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return true;
            if (nodo.Izq == null && nodo.Der == null) return true;
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolLlenoRecursivo(nodo.Izq) && EsArbolLlenoRecursivo(nodo.Der);
            return false;
        }
    }
}