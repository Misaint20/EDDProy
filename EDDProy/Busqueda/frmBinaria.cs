using EDDemo.Busqueda.Clases;
using EDDemo.Ordenamiento.Clases; 
using System;
using System.Windows.Forms;

namespace EDDemo.Busqueda
{
    public partial class frmBinaria : Form
    {
        private int[] numeros;
        private bool estaOrdenado; // Variable para verificar si la lista está ordenada

        public frmBinaria()
        {
            InitializeComponent();
            numeros = new int[0]; // Inicializar el arreglo
            estaOrdenado = false; // Inicializar la variable de estado
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que el número sea válido
            if (int.TryParse(txtDato.Text, out int numero))
            {
                Array.Resize(ref numeros, numeros.Length + 1);
                numeros[numeros.Length - 1] = numero;
                txtDato.Clear();
                ActualizarListBox();
                MessageBox.Show("Número insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            numeros = Binaria.GenerarLista(10);
            ActualizarListBox();
            estaOrdenado = false; // Resetear el estado de ordenación
            MessageBox.Show("Lista de 10 números generada.");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (numeros.Length > 0)
            {
                QuickSort quickSort = new QuickSort();
                quickSort.Ordenar(numeros);
                ActualizarListBox();
                estaOrdenado = true; // Marcar como ordenado
                MessageBox.Show("Lista ordenada.");
            }
            else
            {
                MessageBox.Show("No hay números para ordenar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!estaOrdenado)
            {
                MessageBox.Show("Por favor, ordene la lista antes de buscar.");
                return;
            }

            if (numeros != null && numeros.Length > 0)
            {
                if (int.TryParse(txtBuscar.Text, out int target))
                {
                    int index = Binaria.Buscar(numeros, target);
                    if (index != -1)
                    {
                        MessageBox.Show($"Número encontrado en el índice: {index + 1}");
                    }
                    else
                    {
                        MessageBox.Show("Número no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para buscar.");
                }
            }
            else
            {
                MessageBox.Show("No hay números en la lista para buscar.");
            }
        }

        private void ActualizarListBox()
        {
            listDatos.Items.Clear();
            foreach (var numero in numeros)
            {
                listDatos.Items.Add(numero);
            }
        }
    }
}