namespace Algoritmos_recursividad
{
    partial class ArrayItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayItems));
            this.number = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(45, 168);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(236, 20);
            this.number.TabIndex = 1;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkRed;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(126, 283);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 10;
            this.back.Text = "Cancelar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddElement
            // 
            this.AddElement.BackColor = System.Drawing.Color.LightGray;
            this.AddElement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddElement.Location = new System.Drawing.Point(102, 215);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(129, 33);
            this.AddElement.TabIndex = 11;
            this.AddElement.Text = "Añadir elemento";
            this.AddElement.UseVisualStyleBackColor = false;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elementos del arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese un número al arreglo a la vez";
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.BackColor = System.Drawing.Color.Transparent;
            this.items.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.items.Location = new System.Drawing.Point(87, 329);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(0, 13);
            this.items.TabIndex = 14;
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.item.Location = new System.Drawing.Point(81, 319);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(0, 13);
            this.item.TabIndex = 16;
            // 
            // ArrayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(328, 362);
            this.Controls.Add(this.item);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddElement);
            this.Controls.Add(this.back);
            this.Controls.Add(this.number);
            this.Name = "ArrayItems";
            this.Text = "ArrayItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label items;
        private System.Windows.Forms.Label item;
    }
}