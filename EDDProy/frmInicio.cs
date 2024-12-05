using System;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Busqueda;
using EDDemo.Estructuras_lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmPilas>();
        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmArboles>();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FactorialForm>();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FibonacciForm>();
        }

        private void exponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<ExponentForm>();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<BinarySearchForm>();
        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas pilas = new frmPilas();
            pilas.MdiParent = this;
            pilas.Show();
        }

        private void sumaDeArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<SumArrayForm>();
        }

        private void hanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<HanoiForm>();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmColas>();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmListas>();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmListasDobles>();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmListasCirculares>();
        }

        private void circularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmCircularesDobles>();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmBubble>();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmQuickSort>();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmShellSort>();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmRadix>();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmBinaria>();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<frmHash>();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas colas = new frmColas();
            colas.MdiParent = this;
            colas.Show();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas simples = new frmListas();
            simples.MdiParent = this;
            simples.Show();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles dobles = new frmListasDobles();
            dobles.MdiParent = this;
            dobles.Show();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCirculares circulares = new frmListasCirculares();
            circulares.MdiParent = this;
            circulares.Show();
        }

        private void circularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircularesDobles circularesDobles = new frmCircularesDobles();
            circularesDobles.MdiParent = this;
            circularesDobles.Show();
        }
    }
}