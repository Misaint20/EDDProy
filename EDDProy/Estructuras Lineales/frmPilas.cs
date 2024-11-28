using EDDemo.Estructuras_lineales.Clases; 
using System; 
using System.Windows.Forms; 

namespace EDDemo.Estructuras_lineales
{
    public partial class frmPilas : Form
    {
        // Instancia de la clase Pila
        Pila MiPila = new Pila();

        public frmPilas()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón para insertar un elemento en la pila
        private void btnPush_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado en el TextBox y elimina espacios en blanco al inicio y al final
            string dato = txtDato.Text.Trim();

            // Verifica que el dato no esté vacío
            if (!string.IsNullOrEmpty(dato))
            {
                // Llama al método Push para insertar el dato en la pila
                MiPila.Push(dato);
                // Limpia el TextBox después de insertar el dato
                txtDato.Clear();
                // Muestra el contenido actual de la pila
                MostrarPila();
            }
            else
            {
                // Muestra un mensaje de error si el usuario no ingresó un valor
                MessageBox.Show("Ingresa un valor para insertar");
            }
        }

        // Método para mostrar el contenido de la pila en un ListBox
        private void MostrarPila()
        {
            // Limpia los elementos actuales del ListBox
            listPila.Items.Clear();

            // Verifica si la pila no está vacía
            if (!MiPila.EstaVacia())
            {
                // Llama al método para mostrar el nodo en la lista comenzando desde el tope
                MostrarNodoEnLista(MiPila.Top());
            }
        }

        // Método recursivo para mostrar los nodos en el ListBox
        private void MostrarNodoEnLista(Nodo dato)
        {
            // Verifica si el nodo actual no es null
            if (dato != null)
            {
                // Agrega el dato del nodo actual al ListBox
                listPila.Items.Add(dato.Dato);
                // Llama recursivamente al método para mostrar el siguiente nodo
                MostrarNodoEnLista(dato.Sig);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para eliminar un elemento de la pila
        private void btnPop_Click(object sender, EventArgs e)
        {
            // Verifica si la pila no está vacía
            if (!MiPila.EstaVacia())
            {
                // Llama al método Pop para eliminar el elemento en la parte superior de la pila
                MiPila.Pop();
                // Muestra el contenido actualizado de la pila
                MostrarPila();
            }
            else
            {
                // Muestra un mensaje de error si la pila está vacía
                MessageBox.Show("La pila está vacía");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para vaciar la pila
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            // Mientras la pila no esté vacía, elimina elementos de la pila
            while (!MiPila.EstaVacia())
            {
                MiPila.Pop();
            }

            // Limpia los elementos del ListBox después de vaciar la pila
            listPila.Items.Clear();
        }

        // Evento que se ejecuta al hacer clic en el botón para buscar un elemento en la pila
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado del dato que desea buscar
            string dato = txtBuscar.Text;
            // Llama al método Buscar de la pila y obtiene la posición del dato
            int posicion = MiPila.Buscar(dato);

            // Verifica si la posición devuelta es -1, lo que indica que el dato no fue encontrado en la pila
            if (posicion == -1)
                // Muestra un mensaje al usuario indicando que el dato no se encontró
                MessageBox.Show($"El dato '{dato}' no se encontró en la pila.");
            // Si la posición devuelta es distinta a -1, el dato fue encontrado
            else
                // Muestra un mensaje al usuario con la posición en la que se encontró el dato en la pila
                MessageBox.Show($"El dato '{dato}' se encuentra en la posición: {posicion + 1}");
        }
    }
}