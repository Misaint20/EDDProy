using EDDemo.Estructuras_lineales.Clases; 
using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_lineales
{
    public partial class frmColas : Form
    {
        // Instancia de la clase Cola
        Cola MiCola = new Cola();

        public frmColas()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón para insertar un elemento en la cola
        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado en el TextBox y elimina espacios en blanco al inicio y al final
            string dato = txtDato.Text.Trim();

            // Verifica que el dato no esté vacío
            if (!string.IsNullOrEmpty(dato))
            {
                // Llama al método Enqueue para insertar el dato en la cola
                MiCola.Enqueue(dato);
                // Limpia el TextBox después de insertar el dato
                txtDato.Clear();
                // Muestra el contenido actual de la cola
                MostrarCola();
            }
            else
            {
                // Muestra un mensaje de error si el usuario no ingresó un valor
                MessageBox.Show("Ingresa un valor para insertar");
            }
        }

        // Método para mostrar el contenido de la cola en un ListBox
        private void MostrarCola()
        {
            // Limpia los elementos actuales del ListBox
            listCola.Items.Clear();

            // Verifica si la cola no está vacía
            if (!MiCola.EstaVacia())
            {
                // Llama al método para mostrar todos los nodos en la lista
                MostrarTodosLosNodos();
            }
        }

        // Método para mostrar todos los nodos de la cola en el ListBox
        private void MostrarTodosLosNodos()
        {
            Nodo actual = MiCola.Top(); // Obtiene el nodo en el frente de la cola

            // Recorre la cola hasta que no haya más nodos
            while (actual != null)
            {
                // Agrega el dato del nodo actual al ListBox
                listCola.Items.Add(actual.Dato);
                actual = actual.Sig; // Avanza al siguiente nodo
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para eliminar un elemento de la cola
        private void btnDeque_Click(object sender, EventArgs e)
        {
            // Verifica si la cola no está vacía
            if (!MiCola.EstaVacia())
            {
                // Llama al método Dequeue para eliminar el elemento en el frente de la cola
                MiCola.Dequeue();
                // Muestra el contenido actualizado de la cola
                MostrarCola();
            }
            else
            {
                // Muestra un mensaje de error si la cola está vacía
                MessageBox.Show("La cola está vacía");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para vaciar la cola
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            // Mientras la cola no esté vacía, elimina elementos de la cola
            while (!MiCola.EstaVacia())
            {
                MiCola.Dequeue();
            }

            // Limpia los elementos del ListBox después de vaciar la cola
            listCola.Items.Clear();
        }

        // Evento que se ejecuta al hacer clic en el botón para buscar un elemento en la cola
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado del dato que desea buscar
            string dato = txtBuscar.Text;
            // Llama al método Buscar de la cola y obtiene la posición del dato
            int posicion = MiCola.Buscar(dato);

            // Verifica si la posición devuelta es -1, lo que indica que el dato no fue encontrado en la cola
            if (posicion == -1)
                // Muestra un mensaje al usuario indicando que el dato no se encontró
                MessageBox.Show($"El dato '{dato}' no se encontró en la cola.");
            // Si la posición devuelta es distinta a -1, el dato fue encontrado
            else
                // Muestra un mensaje al usuario con la posición en la que se encontró el dato
                MessageBox.Show($"El dato '{dato}' se encuentra en la posición: {posicion + 1}");
        }
    }
}