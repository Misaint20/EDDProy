using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
