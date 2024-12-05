using EDDemo.Busqueda.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDDemo.Busqueda
{
    public partial class frmHash : Form
    {
        private Hash hashTable;

        public frmHash()
        {
            InitializeComponent();
            hashTable = new Hash();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que la clave y el dato sean distintos
            if (int.TryParse(txtClave.Text, out int clave) && !string.IsNullOrWhiteSpace(txtDato.Text))
            {
                hashTable.Insertar(clave.ToString(), txtDato.Text);
                ActualizarListBox();
                txtClave.Clear();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una clave válida y un valor.");
            }
        }

        private void ActualizarListBox()
        {
            listDatos.Items.Clear();
            List<string> elementos = hashTable.ObtenerElementos();
            foreach (var elemento in elementos)
            {
                listDatos.Items.Add(elemento);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int claveBuscada))
            {
                string resultado = hashTable.Buscar(claveBuscada.ToString());
                if (resultado != null)
                {
                    MessageBox.Show($"Clave {claveBuscada} encontrada: {resultado}");
                }
                else
                {
                    MessageBox.Show($"Clave {claveBuscada} no encontrada en la tabla hash.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una clave válida para buscar.");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++) // Genera 10 números aleatorios
            {
                int clave = random.Next(1, 101);
                string valor = $"Valor {clave}"; // Valor distinto de la clave
                hashTable.Insertar(clave.ToString(), valor);
            }
            ActualizarListBox();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hashTable.CargarDesdeArchivo(openFileDialog.FileName);
                    ActualizarListBox();
                }
            }
        }
    }
}