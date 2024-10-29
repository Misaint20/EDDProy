
namespace EDDemo
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeArraysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursividadToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLinealesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialToolStripMenuItem,
            this.fibonacciToolStripMenuItem,
            this.exponentesToolStripMenuItem,
            this.busquedaBinariaToolStripMenuItem,
            this.sumaDeArraysToolStripMenuItem,
            this.hanoiToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.doblesToolStripMenuItem,
            this.circularesToolStripMenuItem,
            this.circularesDoblesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // estructurasNoLinealesToolStripMenuItem
            // 
            this.estructurasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLinealesToolStripMenuItem.Name = "estructurasNoLinealesToolStripMenuItem";
            this.estructurasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLinealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // exponentesToolStripMenuItem
            // 
            this.exponentesToolStripMenuItem.Name = "exponentesToolStripMenuItem";
            this.exponentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exponentesToolStripMenuItem.Text = "Exponentes";
            this.exponentesToolStripMenuItem.Click += new System.EventHandler(this.exponentesToolStripMenuItem_Click);
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // sumaDeArraysToolStripMenuItem
            // 
            this.sumaDeArraysToolStripMenuItem.Name = "sumaDeArraysToolStripMenuItem";
            this.sumaDeArraysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaDeArraysToolStripMenuItem.Text = "Suma de arrays";
            this.sumaDeArraysToolStripMenuItem.Click += new System.EventHandler(this.sumaDeArraysToolStripMenuItem_Click);
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simplesToolStripMenuItem.Text = "Simples";
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doblesToolStripMenuItem.Text = "Dobles";
            // 
            // circularesToolStripMenuItem
            // 
            this.circularesToolStripMenuItem.Name = "circularesToolStripMenuItem";
            this.circularesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circularesToolStripMenuItem.Text = "Circulares";
            // 
            // circularesDoblesToolStripMenuItem
            // 
            this.circularesDoblesToolStripMenuItem.Name = "circularesDoblesToolStripMenuItem";
            this.circularesDoblesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circularesDoblesToolStripMenuItem.Text = "Circulares dobles";
            // 
            // hanoiToolStripMenuItem
            // 
            this.hanoiToolStripMenuItem.Name = "hanoiToolStripMenuItem";
            this.hanoiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hanoiToolStripMenuItem.Text = "Hanoi";
            this.hanoiToolStripMenuItem.Click += new System.EventHandler(this.hanoiToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Estructura de datos";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeArraysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanoiToolStripMenuItem;
    }
}

