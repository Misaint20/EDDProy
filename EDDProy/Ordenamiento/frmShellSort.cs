using EDDemo.Ordenamiento.Clases;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EDDemo.Ordenamiento
{
    public partial class frmShellSort : Form
    {
        private int[] listaNumeros; // Arreglo para almacenar los números

        public frmShellSort()
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
            listaNumeros = Enumerable.Range(0, 10).Select(_ => random.Next(1, 101)).ToArray(); // Crea 10 números aleatorios entre 1 y 100

            // Actualiza el ListBox
            ActualizarListBox();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordena la lista usando el método de ordenación ShellSort
            ShellSort shellSort = new ShellSort();
            Stopwatch stopwatch = Stopwatch.StartNew(); // Inicio en la medicion de tiempo de ejecucion
            shellSort.Ordenar(listaNumeros);
            stopwatch.Stop(); // Fin en la medicion del tiempo de medicion

            // Actualiza el ListBox para mostrar la lista ordenada
            ActualizarListBoxOrdenada();

            lblTiempo.Text = $"Tiempo de ejecucion: {stopwatch.ElapsedMilliseconds} ms";
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
