using EDDemo.Busqueda.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDDemo.Busqueda
{
    public partial class frmHash : Form
    {
        // Instancia de la clase Hash que representa la tabla hash
        private Hash hashTable;

        public frmHash()
        {
            InitializeComponent();
            // Inicializa la tabla hash
            hashTable = new Hash();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que la clave y el dato sean distintos
            if (int.TryParse(txtClave.Text, out int clave) && !string.IsNullOrWhiteSpace(txtDato.Text))
            {
                // Llama al método Insertar para agregar la clave y el dato a la tabla hash
                hashTable.Insertar(clave.ToString(), txtDato.Text);
                // Actualiza el ListBox para mostrar los elementos actuales de la tabla hash
                ActualizarListBox();
                // Limpia los TextBox después de insertar el dato
                txtClave.Clear();
                txtDato.Clear();
            }
            else
            {
                // Muestra un mensaje de error si la clave o el dato no son válidos
                MessageBox.Show("Por favor, ingresa una clave válida y un valor.");
            }
        }

        // Método para actualizar el contenido del ListBox con los elementos de la tabla hash
        private void ActualizarListBox()
        {
            // Limpia los elementos actuales del ListBox
            listDatos.Items.Clear();
            // Obtiene la lista de elementos de la tabla hash
            List<string> elementos = hashTable.ObtenerElementos();
            // Agrega cada elemento al ListBox
            foreach (var elemento in elementos)
            {
                listDatos.Items.Add(elemento);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica que la clave ingresada sea un número válido
            if (int.TryParse(txtBuscar.Text, out int claveBuscada))
            {
                // Llama al método Buscar de la tabla hash y obtiene el resultado
                string resultado = hashTable.Buscar(claveBuscada.ToString());
                // Verifica si el resultado no es nulo, lo que indica que la clave fue encontrada
                if (resultado != null)
                {
                    // Muestra un mensaje con el resultado de la búsqueda
                    MessageBox.Show($"Clave {claveBuscada} encontrada: {resultado}");
                }
                else
                {
                    // Muestra un mensaje indicando que la clave no fue encontrada
                    MessageBox.Show($"Clave {claveBuscada} no encontrada en la tabla hash.");
                }
            }
            else
            {
                // Muestra un mensaje de error si la clave no es válida
                MessageBox.Show("Por favor, ingresa una clave válida para buscar.");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            // Genera 10 números aleatorios
            for (int i = 0; i < 10; i++)
            {
                int clave = random.Next(1, 101);
                string valor = $"Valor {clave}"; // Valor distinto de la clave
                // Llama al método Insertar para agregar la clave y el valor a la tabla hash
                hashTable.Insertar(clave.ToString(), valor);
            }
            // Actualiza el ListBox para mostrar los nuevos elementos
            ActualizarListBox();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Establece el filtro para archivos de texto
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                // Muestra el diálogo para seleccionar un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Llama al método CargarDesdeArchivo para cargar los elementos en la tabla hash
                    hashTable.CargarDesdeArchivo(openFileDialog.FileName);
                    // Actualiza el ListBox para mostrar los elementos cargados
                    ActualizarListBox();
                }
            }
        }
    }
}