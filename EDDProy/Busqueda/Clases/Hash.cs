using System;
using System.Collections.Generic;
using System.IO;

namespace EDDemo.Busqueda.Clases
{
    public class Hash
    {
        private const int TAMANIO = 100;
        private List<KeyValuePair<string, string>>[] tabla;

        public Hash()
        {
            tabla = new List<KeyValuePair<string, string>>[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i] = new List<KeyValuePair<string, string>>();
            }
        }

        private int FuncionHashAvanzada(uint clave)
        {
            const int primo = 31;
            const uint mezclaBits = 0x9E3779B9;
            uint hash = clave;

            hash ^= (hash >> 16);
            hash *= mezclaBits;
            hash ^= (hash >> 13);
            hash *= primo;
            hash ^= (hash >> 16);

            return (int)(Math.Abs(hash) % TAMANIO);
        }

        public void Insertar(string clave, string valor)
        {
            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            int contador = 0;

            // Verificar si la clave ya existe
            foreach (var par in tabla[indice])
            {
                if (par.Key.StartsWith(clave))
                {
                    contador++;
                }
            }

            // Si hay duplicados, crear una subclave
            if (contador > 0)
            {
                clave += $".{contador}"; // Crear subclave
            }

            tabla[indice].Add(new KeyValuePair<string, string>(clave, valor));
        }

        public string Buscar(string clave)
        {
            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            foreach (var par in tabla[indice])
            {
                if (par.Key == clave)
                {
                    return par.Value;
                }
            }
            return null;
        }

        public void CargarDesdeArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        Insertar(partes[0].Trim(), partes[1].Trim());
                    }
                }
            }
        }

        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>();
            foreach (var lista in tabla)
            {
                foreach (var par in lista)
                {
                    elementos.Add($"{par.Key}: {par.Value}");
                }
            }
            return elementos;
        }
    }
}