using System;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Estructuras_lineales;
using EDDemo.Estructuras_No_Lineales;

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

        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void circularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
