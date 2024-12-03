using EDDemo.Estructuras_lineales.Clases;
using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_lineales
{
    public partial class frmListasCirculares : Form
    {
        // Instancia de la clase Listas
        ListasCirculares miLista = new ListasCirculares();

        public frmListasCirculares()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón para insertar un elemento en la lista
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado en el TextBox y elimina espacios en blanco al inicio y al final
            string dato = txtDato.Text.Trim();
            int posicion;

            // Verifica que el dato no esté vacío y que la posición sea un número válido
            if (!string.IsNullOrEmpty(dato) && int.TryParse(txtPos.Text, out posicion))
            {
                // Llama al método Insertar para agregar el dato en la posición especificada
                miLista.Insertar(dato, posicion - 1);
                // Limpia los TextBox después de insertar el dato
                txtDato.Clear();
                txtPos.Clear();
                // Muestra el contenido actual de la lista
                MostrarLista();
            }
            else
            {
                // Muestra un mensaje de error si el usuario no ingresó un valor
                MessageBox.Show("Ingresa un valor y una posición válidos para insertar");
            }
        }

        // Método para mostrar el contenido de la lista en un ListBox
        private void MostrarLista()
        {
            // Limpia los elementos actuales del ListBox
            lista.Items.Clear();

            // Verifica si la lista no está vacía
            if (!miLista.EstaVacia())
            {
                // Llama al método para mostrar todos los nodos en la lista
                MostrarTodosLosNodos();
            }
        }

        // Método para mostrar todos los nodos de la lista en el ListBox
        private void MostrarTodosLosNodos()
        {
            Nodo actual = miLista.Cabeza(); // Obtiene el primer nodo de la lista

            // Recorre la lista circular hasta que vuelve a la cabeza
            if (actual != null)
            {
                do
                {
                    lista.Items.Add(actual.Dato); // Agrega el dato del nodo actual al ListBox
                    actual = actual.Sig; // Avanza al siguiente nodo
                } while (actual != miLista.Cabeza()); // Para cuando vuelve a la cabeza
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para eliminar un elemento de la lista
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;

            // Verifica que la posición sea un número válido
            if (int.TryParse(txtEliminar.Text, out posicion))
            {
                // Llama al método Eliminar para eliminar el elemento en la posición especificada
                miLista.Eliminar(posicion - 1);
                // Muestra el contenido actualizado de la lista
                MostrarLista();
            }
            else
            {
                // Muestra un mensaje de error si la posición no es válida
                MessageBox.Show("Ingresa una posición válida para eliminar");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para buscar un elemento en la lista
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado del dato que desea buscar
            string dato = txtBuscar.Text.Trim();
            // Llama al método Buscar de la lista y obtiene la posición del dato
            int posicion = miLista.Buscar(dato);

            // Verifica si la posición devuelta es -1, lo que indica que el dato no fue encontrado en la lista
            if (posicion == -1)
                // Muestra un mensaje al usuario indicando que el dato no se encontró
                MessageBox.Show($"El dato '{dato}' no se encontró en la lista.");
            // Si la posición devuelta es distinta a -1, el dato fue encontrado
            else
                // Muestra un mensaje al usuario con la posición en la que se encontró el dato
                MessageBox.Show($"El dato '{dato}' se encuentra en la posición: {posicion + 1}");
        }

        // Evento que se ejecuta al hacer clic en el botón para vaciar la lista
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            // Mientras la lista no esté vacía, elimina elementos de la lista
            while (!miLista.EstaVacia())
            {
                miLista.Eliminar(0);
            }

            // Limpia los elementos del ListBox después de vaciar la lista
            lista.Items.Clear();
        }
    }
}