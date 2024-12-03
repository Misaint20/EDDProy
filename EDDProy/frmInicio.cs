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

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas pilas = new frmPilas();
            pilas.MdiParent = this;
            pilas.Show();
        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorialForm factorial = new FactorialForm();
            factorial.MdiParent = this;
            factorial.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciForm fibonacci = new FibonacciForm();
            fibonacci.MdiParent = this;
            fibonacci.Show();
        }

        private void exponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExponentForm exponent = new ExponentForm();
            exponent.MdiParent = this;
            exponent.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinarySearchForm binary = new BinarySearchForm();
            binary.MdiParent = this;
            binary.Show();
        }

        private void sumaDeArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumArrayForm sumArray = new SumArrayForm();
            sumArray.MdiParent = this;
            sumArray.Show();
        }

        private void hanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HanoiForm hanoi = new HanoiForm();
            hanoi.MdiParent = this;
            hanoi.Show();
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

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBubble bubble = new frmBubble();
            bubble.MdiParent = this;
            bubble.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort quickSort = new frmQuickSort();
            quickSort.MdiParent = this;
            quickSort.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort shellSort = new frmShellSort();
            shellSort.MdiParent = this;
            shellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix radix = new frmRadix();
            radix.MdiParent = this;
            radix.Show();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinaria binaria = new frmBinaria();
            binaria.MdiParent = this;
            binaria.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHash hash = new frmHash();
            hash.MdiParent = this;
            hash.Show();
        }

        private void hashAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHashAvanced hashAvanced = new frmHashAvanced();
            hashAvanced.MdiParent = this;
            hashAvanced.Show();
        }
    }
}
