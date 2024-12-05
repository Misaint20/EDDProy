using System;
using System.Collections.Generic;
using System.IO;

namespace EDDemo.Busqueda.Clases
{
    public class Hash
    {
        // Tamaño de la tabla hash
        private const int TAMANIO = 100;
        // Arreglo de listas para almacenar los pares clave-valor
        private List<KeyValuePair<string, string>>[] tabla;

        public Hash()
        {
            // Inicializa la tabla hash con listas vacías
            tabla = new List<KeyValuePair<string, string>>[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i] = new List<KeyValuePair<string, string>>();
            }
        }

        // Función hash avanzada que calcula el índice en la tabla hash
        private int FuncionHashAvanzada(uint clave)
        {
            const int primo = 31; // Número primo utilizado en el cálculo
            const uint mezclaBits = 0x9E3779B9; // Constante para mezclar bits
            uint hash = clave;

            // Aplica varias operaciones bit a bit y multiplicaciones para calcular el hash
            hash ^= (hash >> 16);
            hash *= mezclaBits;
            hash ^= (hash >> 13);
            hash *= primo;
            hash ^= (hash >> 16);

            // Devuelve el índice en la tabla hash
            return (int)(Math.Abs(hash) % TAMANIO);
        }

        // Método para insertar un par clave-valor en la tabla hash
        public void Insertar(string clave, string valor)
        {
            // Calcula el índice usando la función hash
            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            int contador = 0;

            // Verificar si la clave ya existe en la tabla
            foreach (var par in tabla[indice])
            {
                if (par.Key.StartsWith(clave))
                {
                    contador++; // Incrementa el contador si hay duplicados
                }
            }

            // Si hay duplicados, crear una subclave
            if (contador > 0)
            {
                clave += $".{contador}"; // Crear subclave para evitar colisiones
            }

            // Agrega el nuevo par clave-valor a la tabla
            tabla[indice].Add(new KeyValuePair<string, string>(clave, valor));
        }

        // Método para buscar un valor asociado a una clave en la tabla hash
        public string Buscar(string clave)
        {
            // Calcula el índice usando la función hash
            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            foreach (var par in tabla[indice])
            {
                // Verifica si la clave coincide
                if (par.Key == clave)
                {
                    return par.Value; // Devuelve el valor asociado a la clave
                }
            }
            return null; // Devuelve null si la clave no se encuentra
        }

        // Método para cargar pares clave-valor desde un archivo
        public void CargarDesdeArchivo(string ruta)
        {
            // Verifica si el archivo existe
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta); // Lee todas las líneas del archivo
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(','); // Divide la línea en partes
                    // Verifica que la línea tenga exactamente dos partes
                    if (partes.Length == 2)
                    {
                        // Inserta la clave y el valor en la tabla hash
                        Insertar(partes[0].Trim(), partes[1].Trim());
                    }
                }
            }
        }

        // Método para obtener todos los elementos de la tabla hash
        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>();
            // Recorre la tabla y agrega los pares clave-valor a la lista de elementos
            foreach (var lista in tabla)
            {
                foreach (var par in lista)
                {
                    elementos.Add($"{par.Key}: {par.Value}"); // Formatea el par como cadena
                }
            }
            return elementos; // Devuelve la lista de elementos
        }
    }
}