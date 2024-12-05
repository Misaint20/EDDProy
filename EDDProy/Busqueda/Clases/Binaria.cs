using System;
using System.Collections.Generic;

namespace EDDemo.Busqueda.Clases
{
    public class Binaria
    {
        public static int Buscar(int[] array, int target)
        {
            return Buscar(array, target, 0, array.Length - 1);
        }

        private static int Buscar(int[] array, int target, int low, int high)
        {
            // Caso base: rango de búsqueda vacío
            if (low > high)
                return -1;

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

        public static List<int> ObtenerIndices(int[] array, int target)
        {
            List<int> indices = new List<int>();
            int index = Buscar(array, target);
            if (index != -1)
            {
                indices.Add(index);
                // Buscar hacia la izquierda
                for (int i = index - 1; i >= 0 && array[i] == target; i--)
                {
                    indices.Add(i);
                }
                // Buscar hacia la derecha
                for (int i = index + 1; i < array.Length && array[i] == target; i++)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static int[] GenerarLista(int cantidad)
        {
            Random random = new Random();
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = random.Next(1, 101); // Números entre 1 y 100
            }
            return numeros;
        }
    }
}