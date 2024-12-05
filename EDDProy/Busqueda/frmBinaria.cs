using EDDemo.Busqueda.Clases; // Importa las clases de búsqueda
using EDDemo.Ordenamiento.Clases; // Importa las clases de ordenamiento
using System;
using System.Windows.Forms; // Importa las clases de Windows Forms

namespace EDDemo.Busqueda
{
    public partial class frmBinaria : Form
    {
        private int[] numeros; // Arreglo para almacenar los números ingresados
        private bool estaOrdenado; // Variable para verificar si la lista está ordenada

        public frmBinaria()
        {
            InitializeComponent(); // Inicializa los componentes de la interfaz
            numeros = new int[0]; // Inicializa el arreglo vacío
            estaOrdenado = false; // Inicializa la variable de estado como falso
        }

        // Evento que se dispara al hacer clic en el botón de insertar
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que el número sea válido
            if (int.TryParse(txtDato.Text, out int numero))
            {
                // Redimensiona el arreglo para agregar un nuevo número
                Array.Resize(ref numeros, numeros.Length + 1);
                numeros[numeros.Length - 1] = numero; // Asigna el nuevo número al final del arreglo
                txtDato.Clear(); // Limpia el campo de texto
                ActualizarListBox(); // Actualiza la lista mostrada en la interfaz
                MessageBox.Show("Número insertado correctamente."); // Mensaje de confirmación
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido."); // Mensaje de error
            }
        }

        // Evento que se dispara al hacer clic en el botón de generar lista
        private void btnLista_Click(object sender, EventArgs e)
        {
            // Genera una lista de 10 números aleatorios
            numeros = Binaria.GenerarLista(10);
            ActualizarListBox(); // Actualiza la lista mostrada en la interfaz
            estaOrdenado = false; // Resetear el estado de ordenación
            MessageBox.Show("Lista de 10 números generada."); // Mensaje de confirmación
        }

        // Evento que se dispara al hacer clic en el botón de ordenar
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Verifica que haya números en el arreglo
            if (numeros.Length > 0)
            {
                QuickSort quickSort = new QuickSort(); // Crea una instancia de QuickSort
                quickSort.Ordenar(numeros); // Ordena el arreglo de números
                ActualizarListBox(); // Actualiza la lista mostrada en la interfaz
                estaOrdenado = true; // Marca como ordenado
                MessageBox.Show("Lista ordenada."); // Mensaje de confirmación
            }
            else
            {
                MessageBox.Show("No hay números para ordenar."); // Mensaje de error
            }
        }

        // Evento que se dispara al hacer clic en el botón de buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si la lista está ordenada antes de buscar
            if (!estaOrdenado)
            {
                MessageBox.Show("Por favor, ordene la lista antes de buscar."); // Mensaje de advertencia
                return; // Sale del método
            }

            // Verifica que el arreglo no sea nulo y tenga elementos
            if (numeros != null && numeros.Length > 0)
            {
                // Asegurarse de que el número a buscar sea válido
                if (int.TryParse(txtBuscar.Text, out int target))
                {
                    // Realiza la búsqueda del número en el arreglo
                    int index = Binaria.Buscar(numeros, target);
                    if (index != -1)
                    {
                        MessageBox.Show($"Número encontrado en el índice: {index + 1}"); // Mensaje de éxito
                    }
                    else
                    {
                        MessageBox.Show("Número no encontrado."); // Mensaje de error
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para buscar."); // Mensaje de error
                }
            }
            else
            {
                MessageBox.Show("No hay números en la lista para buscar."); // Mensaje de error
            }
        }

        // Método para actualizar el ListBox con los números actuales
        private void ActualizarListBox()
        {
            listDatos.Items.Clear(); // Limpia los elementos actuales del ListBox
            foreach (var numero in numeros)
            {
                listDatos.Items.Add(numero); // Agrega cada número al ListBox
            }
        }
    }
}