namespace EDDemo.Busqueda
{
    partial class frmBinaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Dato:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(176, 229);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 101;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(187, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 100;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Lista";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(176, 145);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 23);
            this.btnOrdenar.TabIndex = 98;
            this.btnOrdenar.Text = "Ordenar Datos";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Dato:";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(189, 88);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 96;
            this.btnLista.Text = "Crear lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.Location = new System.Drawing.Point(19, 180);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(137, 160);
            this.listDatos.TabIndex = 95;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(30, 90);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(50, 20);
            this.txtDato.TabIndex = 94;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(19, 116);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 93;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Busqueda Binaria";
            // 
            // frmBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Name = "frmBinaria";
            this.Text = "frmBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
    }
}