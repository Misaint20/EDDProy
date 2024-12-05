using System;

namespace EDDemo.Ordenamiento.Clases
{
    internal class QuickSort
    {
        // Método para ordenar un arreglo de enteros utilizando el algoritmo de ordenación QuickSort
        public void Ordenar(int[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                throw new ArgumentException("El arreglo está vacío o es nulo, no se puede ordenar.");
            }

            QuickSortAlgorithm(datos, 0, datos.Length - 1); // Llama al método recursivo
        }

        // Método recursivo para implementar el algoritmo QuickSort
        private void QuickSortAlgorithm(int[] datos, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(datos, low, high); // Encuentra el índice del pivote
                QuickSortAlgorithm(datos, low, pivotIndex - 1); // Ordena la parte izquierda
                QuickSortAlgorithm(datos, pivotIndex + 1, high); // Ordena la parte derecha
            }
        }

        // Método para particionar el arreglo y encontrar el índice del pivote
        private int Partition(int[] datos, int low, int high)
        {
            int pivot = datos[high]; // Selecciona el último elemento como pivote
            int i = low - 1; // Índice del elemento más pequeño

            // Recorre el arreglo
            for (int j = low; j < high; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (datos[j] <= pivot)
                {
                    i++; // Incrementa el índice del elemento más pequeño
                    Swap(ref datos[i], ref datos[j]); // Intercambia los elementos
                }
            }
            Swap(ref datos[i + 1], ref datos[high]); // Coloca el pivote en su posición correcta
            return i + 1; // Retorna el índice del pivote
        }

        // Método para intercambiar los datos de dos elementos
        private void Swap(ref int a, ref int b)
        {
            int temp = a; // Guarda el dato del primer elemento
            a = b;        // Asigna el dato del segundo elemento al primero
            b = temp;    // Asigna el dato guardado al segundo elemento
        }
    }
}