using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                int fact = int.Parse(number.Text);

                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = Factorial.run(fact);
                stopwatch.Stop();

                string message;
                //labelResult.Text = "El resultado factorial de tu numero es: " + result.ToString(); 
                //time.Text = "El tiempo de procesamiento fue de: " + stopwatch.ElapsedMilliseconds + " ms";
                //complex.Text = "La complejidad del algoritmo fue de O(" + fact + ")";

                message = $"El resultado factorial de tu numero es: " + result.ToString();
                message += $"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                message += $"\nComplejidad: O({fact})";

                MessageBox.Show(message);

            } catch
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
