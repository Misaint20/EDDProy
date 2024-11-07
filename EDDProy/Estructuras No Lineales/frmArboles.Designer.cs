
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.InOrdenCheck = new System.Windows.Forms.CheckBox();
            this.PreOrdenCheck = new System.Windows.Forms.CheckBox();
            this.PostOrdenCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarNodo = new System.Windows.Forms.Button();
            this.strBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminarNodo = new System.Windows.Forms.Button();
            this.deleteNodo = new System.Windows.Forms.TextBox();
            this.NivelesCheck = new System.Windows.Forms.CheckBox();
            this.lblRecorridoNiveles = new System.Windows.Forms.Label();
            this.infoArbol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 16);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(6, 198);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(509, 301);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(438, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(372, 11);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(62, 24);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(237, 16);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(62, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 21);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(104, 48);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(40, 54);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(275, 108);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoPostOrden.TabIndex = 10;
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(274, 62);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoInOrden.TabIndex = 13;
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(275, 85);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoPreOrden.TabIndex = 14;
            // 
            // InOrdenCheck
            // 
            this.InOrdenCheck.AutoSize = true;
            this.InOrdenCheck.Location = new System.Drawing.Point(194, 61);
            this.InOrdenCheck.Name = "InOrdenCheck";
            this.InOrdenCheck.Size = new System.Drawing.Size(67, 17);
            this.InOrdenCheck.TabIndex = 15;
            this.InOrdenCheck.Text = "InOrden:";
            this.InOrdenCheck.UseVisualStyleBackColor = true;
            // 
            // PreOrdenCheck
            // 
            this.PreOrdenCheck.AutoSize = true;
            this.PreOrdenCheck.Location = new System.Drawing.Point(194, 84);
            this.PreOrdenCheck.Name = "PreOrdenCheck";
            this.PreOrdenCheck.Size = new System.Drawing.Size(74, 17);
            this.PreOrdenCheck.TabIndex = 16;
            this.PreOrdenCheck.Text = "PreOrden:";
            this.PreOrdenCheck.UseVisualStyleBackColor = true;
            // 
            // PostOrdenCheck
            // 
            this.PostOrdenCheck.AutoSize = true;
            this.PostOrdenCheck.Location = new System.Drawing.Point(194, 107);
            this.PostOrdenCheck.Name = "PostOrdenCheck";
            this.PostOrdenCheck.Size = new System.Drawing.Size(79, 17);
            this.PostOrdenCheck.TabIndex = 17;
            this.PostOrdenCheck.Text = "PostOrden:";
            this.PostOrdenCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dato :";
            // 
            // buscarNodo
            // 
            this.buscarNodo.Location = new System.Drawing.Point(104, 149);
            this.buscarNodo.Margin = new System.Windows.Forms.Padding(2);
            this.buscarNodo.Name = "buscarNodo";
            this.buscarNodo.Size = new System.Drawing.Size(62, 24);
            this.buscarNodo.TabIndex = 19;
            this.buscarNodo.Text = "Buscar";
            this.buscarNodo.UseVisualStyleBackColor = true;
            this.buscarNodo.Click += new System.EventHandler(this.buscarNodo_Click);
            // 
            // strBuscar
            // 
            this.strBuscar.Location = new System.Drawing.Point(42, 149);
            this.strBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.strBuscar.Multiline = true;
            this.strBuscar.Name = "strBuscar";
            this.strBuscar.Size = new System.Drawing.Size(52, 26);
            this.strBuscar.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dato :";
            // 
            // eliminarNodo
            // 
            this.eliminarNodo.Location = new System.Drawing.Point(438, 151);
            this.eliminarNodo.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarNodo.Name = "eliminarNodo";
            this.eliminarNodo.Size = new System.Drawing.Size(62, 24);
            this.eliminarNodo.TabIndex = 22;
            this.eliminarNodo.Text = "Eliminar";
            this.eliminarNodo.UseVisualStyleBackColor = true;
            this.eliminarNodo.Click += new System.EventHandler(this.eliminarNodo_Click);
            // 
            // deleteNodo
            // 
            this.deleteNodo.Location = new System.Drawing.Point(376, 151);
            this.deleteNodo.Margin = new System.Windows.Forms.Padding(2);
            this.deleteNodo.Multiline = true;
            this.deleteNodo.Name = "deleteNodo";
            this.deleteNodo.Size = new System.Drawing.Size(52, 26);
            this.deleteNodo.TabIndex = 21;
            // 
            // NivelesCheck
            // 
            this.NivelesCheck.AutoSize = true;
            this.NivelesCheck.Location = new System.Drawing.Point(192, 130);
            this.NivelesCheck.Name = "NivelesCheck";
            this.NivelesCheck.Size = new System.Drawing.Size(81, 17);
            this.NivelesCheck.TabIndex = 26;
            this.NivelesCheck.Text = "Por niveles:";
            this.NivelesCheck.UseVisualStyleBackColor = true;
            // 
            // lblRecorridoNiveles
            // 
            this.lblRecorridoNiveles.AutoSize = true;
            this.lblRecorridoNiveles.Location = new System.Drawing.Point(272, 131);
            this.lblRecorridoNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoNiveles.Name = "lblRecorridoNiveles";
            this.lblRecorridoNiveles.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoNiveles.TabIndex = 25;
            // 
            // infoArbol
            // 
            this.infoArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoArbol.Location = new System.Drawing.Point(303, 11);
            this.infoArbol.Margin = new System.Windows.Forms.Padding(2);
            this.infoArbol.Name = "infoArbol";
            this.infoArbol.Size = new System.Drawing.Size(62, 24);
            this.infoArbol.TabIndex = 27;
            this.infoArbol.Text = "Info";
            this.infoArbol.UseVisualStyleBackColor = true;
            this.infoArbol.Click += new System.EventHandler(this.infoArbol_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 389);
            this.Controls.Add(this.infoArbol);
            this.Controls.Add(this.NivelesCheck);
            this.Controls.Add(this.lblRecorridoNiveles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eliminarNodo);
            this.Controls.Add(this.deleteNodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarNodo);
            this.Controls.Add(this.strBuscar);
            this.Controls.Add(this.PostOrdenCheck);
            this.Controls.Add(this.PreOrdenCheck);
            this.Controls.Add(this.InOrdenCheck);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.CheckBox InOrdenCheck;
        private System.Windows.Forms.CheckBox PreOrdenCheck;
        private System.Windows.Forms.CheckBox PostOrdenCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarNodo;
        private System.Windows.Forms.TextBox strBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eliminarNodo;
        private System.Windows.Forms.TextBox deleteNodo;
        private System.Windows.Forms.CheckBox NivelesCheck;
        private System.Windows.Forms.Label lblRecorridoNiveles;
        private System.Windows.Forms.Button infoArbol;
    }
}