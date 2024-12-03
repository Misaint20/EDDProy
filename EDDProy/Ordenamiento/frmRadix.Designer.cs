namespace EDDemo.Ordenamiento
{
    partial class frmRadix
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
            this.label3 = new System.Windows.Forms.Label();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Lista ordenada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Lista original";
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(147, 170);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(87, 173);
            this.lista2.TabIndex = 71;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(266, 191);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 70;
            this.btnOrdenar.Text = "Ordenar lista";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Dato:";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(266, 118);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 67;
            this.btnLista.Text = "Crear lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(24, 170);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(87, 173);
            this.lista1.TabIndex = 66;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(109, 92);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(50, 20);
            this.txtDato.TabIndex = 65;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(71, 118);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 64;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "RadixSort";
            // 
            // frmRadix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Name = "frmRadix";
            this.Text = "frmRadix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
    }
}