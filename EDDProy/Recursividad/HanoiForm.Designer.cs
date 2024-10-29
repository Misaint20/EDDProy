namespace Algoritmos_recursividad
{
    partial class HanoiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HanoiForm));
            this.complex = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Movimientos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diskNumeric = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // complex
            // 
            this.complex.AutoSize = true;
            this.complex.BackColor = System.Drawing.Color.Transparent;
            this.complex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.complex.Location = new System.Drawing.Point(33, 239);
            this.complex.Name = "complex";
            this.complex.Size = new System.Drawing.Size(204, 13);
            this.complex.TabIndex = 30;
            this.complex.Text = "La complejidad del algoritmo es de O(2^n)";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightGray;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Location = new System.Drawing.Point(428, 365);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(139, 42);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // Movimientos
            // 
            this.Movimientos.FormattingEnabled = true;
            this.Movimientos.Location = new System.Drawing.Point(247, 217);
            this.Movimientos.Name = "Movimientos";
            this.Movimientos.Size = new System.Drawing.Size(320, 108);
            this.Movimientos.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(299, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ingrese el número de discos";
            // 
            // diskNumeric
            // 
            this.diskNumeric.Location = new System.Drawing.Point(329, 168);
            this.diskNumeric.Name = "diskNumeric";
            this.diskNumeric.Size = new System.Drawing.Size(120, 20);
            this.diskNumeric.TabIndex = 26;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightGray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Location = new System.Drawing.Point(247, 365);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(139, 42);
            this.start.TabIndex = 25;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Torre de Hanoi";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkRed;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(692, 384);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 23;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Location = new System.Drawing.Point(33, 268);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 13);
            this.time.TabIndex = 31;
            // 
            // HanoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.complex);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Movimientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diskNumeric);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "HanoiForm";
            this.Text = "HanoiForm";
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label complex;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListBox Movimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown diskNumeric;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label time;
    }
}