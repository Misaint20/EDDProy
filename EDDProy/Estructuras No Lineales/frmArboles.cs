using System;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        private ArbolBusqueda miArbol;
        private NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.strArbol = "";
                miArbol.InsertaNodo(dato, ref miRaiz);
                ActualizarVistaArbol();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarVistaArbol()
        {
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (miArbol.EstaVacio())
            {
                MessageBox.Show("El árbol ya está vacío.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar todo el árbol?", "Confirmar poda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                LimpiarArbol();
                MessageBox.Show("El árbol ha sido podado completamente.");
            }

        }

        private void LimpiarArbol()
        {
            miArbol.PodarArbol();
            miRaiz = null;
            txtArbol.Text = "";
            LimpiarLblsRecorrido();
            DesmarcarCheckboxes();
        }

        private void LimpiarLblsRecorrido()
        {
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            lblRecorridoNiveles.Text = "";
        }

        private void DesmarcarCheckboxes()
        {
            InOrdenCheck.Checked = false;
            PreOrdenCheck.Checked = false;
            PostOrdenCheck.Checked = false;
            NivelesCheck.Checked = false;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío", "Árbol vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string graphVizString = GenerarGraphVizString();
            MostrarGrafica(graphVizString);
        }

        private string GenerarGraphVizString()
        {
            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            return b.ToString();
        }

        private void MostrarGrafica(string graphVizString)
        {
            Bitmap bm = FileDotEngine.Run(graphVizString);
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (!PreOrdenCheck.Checked && !InOrdenCheck.Checked &&
                !PostOrdenCheck.Checked && !NivelesCheck.Checked)
            {
                MessageBox.Show("Seleccione al menos un método de recorrido antes de comenzar.",
                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LimpiarLblsRecorrido();

            if (PreOrdenCheck.Checked)
                RecorrerArbol(miArbol.PreOrden, lblRecorridoPreOrden, "PreOrden");

            if (InOrdenCheck.Checked)
                RecorrerArbol(miArbol.InOrden, lblRecorridoInOrden, "InOrden");

            if (PostOrdenCheck.Checked)
                RecorrerArbol(miArbol.PostOrden, lblRecorridoPostOrden, "PostOrden");

            if (NivelesCheck.Checked)
                RecorrerArbol(miArbol.RecorridoPorNiveles, lblRecorridoNiveles, "Por Niveles");
        }

        private void RecorrerArbol(Action<NodoBinario> recorrido, Label lblResultado, string tipoRecorrido)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblResultado.Text = $"El árbol está vacío ({tipoRecorrido})";
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            recorrido(miRaiz);
            sw.Stop();

            lblResultado.Text = $"{tipoRecorrido}: {miArbol.strRecorrido.TrimEnd(',')} (Tiempo: {sw.ElapsedMilliseconds}ms)";
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            LimpiarArbol();
            int numNodos = (int)txtNodos.Value;
            Random rnd = new Random();

            for (int i = 1; i <= numNodos; i++)
            {
                int dato = rnd.Next(1, 100);
                miRaiz = miArbol.RegresaRaiz();
                miArbol.InsertaNodo(dato, ref miRaiz);
            }
            ActualizarVistaArbol();
        }

        private void buscarNodo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(strBuscar.Text, out int dato))
            {
                miRaiz = miArbol.RegresaRaiz();

                if (miRaiz == null)
                {
                    MessageBox.Show("El árbol está vacío", "Árbol vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool resultado = miArbol.BuscarNodo(dato, miRaiz);
                string mensaje = resultado
                    ? $"El dato {dato} fue encontrado en el árbol."
                    : $"El dato {dato} no fue encontrado en el árbol.";

                MessageBox.Show(mensaje, "Resultado de búsqueda", MessageBoxButtons.OK,
                    resultado ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para buscar.",
                    "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            strBuscar.Text = "";
        }

        private void eliminarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(deleteNodo.Text))
                {
                    MessageBox.Show("Por favor ingrese un valor para eliminar");
                    return;
                }

                int datoEliminar = int.Parse(deleteNodo.Text);

                if (miArbol.EliminarNodo(datoEliminar))
                {
                    // Actualizar la visualización del árbol
                    miRaiz = miArbol.RegresaRaiz();
                    miArbol.strArbol = "";
                    miArbol.MuestraArbolAcostado(1, miRaiz);
                    txtArbol.Text = miArbol.strArbol;

                    MessageBox.Show($"El nodo {datoEliminar} ha sido eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show($"El nodo {datoEliminar} no se encontró en el árbol");
                }

                txtDato.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el nodo: {ex.Message}");
            }
        }

        private void infoArbol_Click(object sender, EventArgs e)
        {
            if (miArbol.EstaVacio())
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            string info = $"Altura del árbol: {miArbol.ObtenerAltura()}\n" +
                         $"Cantidad de hojas: {miArbol.ContarHojas()}\n" +
                         $"Total de nodos: {miArbol.ContarNodos()}\n " +
                         $"Es árbol completo: {miArbol.EsArbolCompleto()}\n" +
                         $"Es árbol lleno: {miArbol.EsArbolLleno()}";

            MessageBox.Show(info, "Informacion del Arbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   
    }
}