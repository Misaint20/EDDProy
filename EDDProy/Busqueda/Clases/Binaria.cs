using System;
using System.Collections.Generic;

namespace EDDemo.Busqueda.Clases
{
    public class Binaria
    {
        // Método público para buscar un elemento en un arreglo usando búsqueda binaria
        public static int Buscar(int[] array, int target)
        {
            // Llama al método privado que realiza la búsqueda binaria
            return Buscar(array, target, 0, array.Length - 1);
        }

        // Método privado que implementa la búsqueda binaria de manera recursiva
        private static int Buscar(int[] array, int target, int low, int high)
        {
            // Caso base: rango de búsqueda vacío
            if (low > high)
                return -1; // Devuelve -1 si el elemento no se encuentra

            // Calcula el índice medio del rango actual
            int mid = (low + high) / 2;

            // Si el elemento es encontrado, devuelve su índice
            if (array[mid] == target)
                return mid;
            // Si el elemento es menor que el elemento medio, busca en la mitad izquierda
            else if (array[mid] < target)
                return Buscar(array, target, mid + 1, high);
            // Si el elemento es mayor que el elemento medio, busca en la mitad derecha
            else
                return Buscar(array, target, low, mid - 1);
        }

        // Método público para obtener todos los índices de un elemento en un arreglo
        public static List<int> ObtenerIndices(int[] array, int target)
        {
            List<int> indices = new List<int>(); // Lista para almacenar los índices encontrados
            int index = Buscar(array, target); // Busca el primer índice del elemento

            // Si el elemento fue encontrado
            if (index != -1)
            {
                indices.Add(index); // Agrega el índice encontrado a la lista

                // Buscar hacia la izquierda para encontrar otros índices del mismo elemento
                for (int i = index - 1; i >= 0 && array[i] == target; i--)
                {
                    indices.Add(i); // Agrega el índice a la lista
                }

                // Buscar hacia la derecha para encontrar otros índices del mismo elemento
                for (int i = index + 1; i < array.Length && array[i] == target; i++)
                {
                    indices.Add(i); // Agrega el índice a la lista
                }
            }
            return indices; // Devuelve la lista de índices encontrados
        }

        // Método para generar un arreglo de números aleatorios
        public static int[] GenerarLista(int cantidad)
        {
            Random random = new Random(); // Crea una instancia de Random para generar números aleatorios
            int[] numeros = new int[cantidad]; // Crea un arreglo para almacenar los números

            // Llena el arreglo con números aleatorios entre 1 y 100
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = random.Next(1, 101); // Números entre 1 y 100
            }
            return numeros; // Devuelve el arreglo de números generados
        }
    }
}