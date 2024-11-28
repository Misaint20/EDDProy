namespace EDDemo.Estructuras_lineales
{
    partial class frmColas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnDeque = new System.Windows.Forms.Button();
            this.listCola = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dato:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(271, 204);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(282, 230);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dato:";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(279, 104);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 15;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnDeque
            // 
            this.btnDeque.Location = new System.Drawing.Point(279, 75);
            this.btnDeque.Name = "btnDeque";
            this.btnDeque.Size = new System.Drawing.Size(75, 23);
            this.btnDeque.TabIndex = 14;
            this.btnDeque.Text = "Deque";
            this.btnDeque.UseVisualStyleBackColor = true;
            this.btnDeque.Click += new System.EventHandler(this.btnDeque_Click);
            // 
            // listCola
            // 
            this.listCola.FormattingEnabled = true;
            this.listCola.Location = new System.Drawing.Point(41, 153);
            this.listCola.Name = "listCola";
            this.listCola.Size = new System.Drawing.Size(147, 160);
            this.listCola.TabIndex = 13;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(77, 82);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 12;
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(88, 108);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(75, 23);
            this.btnQueue.TabIndex = 11;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Colas";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnDeque);
            this.Controls.Add(this.listCola);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.label1);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnDeque;
        private System.Windows.Forms.ListBox listCola;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Label label1;
    }
}