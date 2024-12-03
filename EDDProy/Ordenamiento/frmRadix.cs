using EDDemo.Ordenamiento.Clases;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EDDemo.Ordenamiento
{
    public partial class frmRadix : Form
    {
        private int[] listaNumeros; // Arreglo para almacenar los números

        public frmRadix()
        {
            InitializeComponent();
            listaNumeros = new int[0]; // Inicializa la lista vacía
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Agrega un número manualmente a la lista
            if (int.TryParse(txtDato.Text, out int numero))
            {
                // Agrega el número a la lista
                Array.Resize(ref listaNumeros, listaNumeros.Length + 1);
                listaNumeros[listaNumeros.Length - 1] = numero;

                // Actualiza el ListBox
                ActualizarListBox();
                txtDato.Clear(); // Limpia el TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listaNumeros = Enumerable.Range(0, 10).Select(_ => random.Next(-100, 101)).ToArray(); // Crea 10 números aleatorios entre -100 y 100

            // Actualiza el ListBox
            ActualizarListBox();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordena la lista usando el método de ordenación Radix Sort
            RadixSort radixSort = new RadixSort();
            radixSort.Ordenar(listaNumeros);

            // Actualiza el ListBox para mostrar la lista ordenada
            ActualizarListBoxOrdenada();
        }

        private void ActualizarListBox()
        {
            lista1.Items.Clear(); // Limpia el ListBox
            foreach (var numero in listaNumeros)
            {
                lista1.Items.Add(numero); // Agrega cada número al ListBox
            }
        }

        private void ActualizarListBoxOrdenada()
        {
            lista2.Items.Clear(); // Limpia el ListBox de la lista ordenada
            foreach (var numero in listaNumeros)
            {
                lista2.Items.Add(numero); // Agrega cada número ordenado al ListBox
            }
        }
    }
}
