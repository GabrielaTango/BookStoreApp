namespace UI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            zonasToolStripMenuItem = new ToolStripMenuItem();
            subZonasToolStripMenuItem = new ToolStripMenuItem();
            provinciasToolStripMenuItem = new ToolStripMenuItem();
            condicionVentaToolStripMenuItem = new ToolStripMenuItem();
            vendedoresToolStripMenuItem = new ToolStripMenuItem();
            listasDePreciosToolStripMenuItem = new ToolStripMenuItem();
            comrpobanToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            notaDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            preciosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, articulosToolStripMenuItem, preciosToolStripMenuItem, tablasToolStripMenuItem, comrpobanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(81, 24);
            articulosToolStripMenuItem.Text = "Articulos";
            articulosToolStripMenuItem.Click += articulosToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zonasToolStripMenuItem, subZonasToolStripMenuItem, provinciasToolStripMenuItem, condicionVentaToolStripMenuItem, vendedoresToolStripMenuItem, listasDePreciosToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(64, 24);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // zonasToolStripMenuItem
            // 
            zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            zonasToolStripMenuItem.Size = new Size(200, 26);
            zonasToolStripMenuItem.Text = "Zonas";
            zonasToolStripMenuItem.Click += zonasToolStripMenuItem_Click;
            // 
            // subZonasToolStripMenuItem
            // 
            subZonasToolStripMenuItem.Name = "subZonasToolStripMenuItem";
            subZonasToolStripMenuItem.Size = new Size(200, 26);
            subZonasToolStripMenuItem.Text = "Sub Zonas";
            subZonasToolStripMenuItem.Click += subZonasToolStripMenuItem_Click;
            // 
            // provinciasToolStripMenuItem
            // 
            provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            provinciasToolStripMenuItem.Size = new Size(200, 26);
            provinciasToolStripMenuItem.Text = "Provincias";
            provinciasToolStripMenuItem.Click += provinciasToolStripMenuItem_Click;
            // 
            // condicionVentaToolStripMenuItem
            // 
            condicionVentaToolStripMenuItem.Name = "condicionVentaToolStripMenuItem";
            condicionVentaToolStripMenuItem.Size = new Size(200, 26);
            condicionVentaToolStripMenuItem.Text = "Condicion Venta";
            condicionVentaToolStripMenuItem.Click += condicionVentaToolStripMenuItem_Click;
            // 
            // vendedoresToolStripMenuItem
            // 
            vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            vendedoresToolStripMenuItem.Size = new Size(200, 26);
            vendedoresToolStripMenuItem.Text = "Vendedores";
            vendedoresToolStripMenuItem.Click += vendedoresToolStripMenuItem_Click;
            // 
            // listasDePreciosToolStripMenuItem
            // 
            listasDePreciosToolStripMenuItem.Name = "listasDePreciosToolStripMenuItem";
            listasDePreciosToolStripMenuItem.Size = new Size(200, 26);
            listasDePreciosToolStripMenuItem.Text = "Listas de Precios";
            listasDePreciosToolStripMenuItem.Click += listasDePreciosToolStripMenuItem_Click;
            // 
            // comrpobanToolStripMenuItem
            // 
            comrpobanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem, notaDeCreditoToolStripMenuItem });
            comrpobanToolStripMenuItem.Name = "comrpobanToolStripMenuItem";
            comrpobanToolStripMenuItem.Size = new Size(121, 24);
            comrpobanToolStripMenuItem.Text = "Comprobantes";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(199, 26);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // notaDeCreditoToolStripMenuItem
            // 
            notaDeCreditoToolStripMenuItem.Name = "notaDeCreditoToolStripMenuItem";
            notaDeCreditoToolStripMenuItem.Size = new Size(199, 26);
            notaDeCreditoToolStripMenuItem.Text = "Nota de Credito";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 154);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(543, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 154);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books;
            pictureBox1.Location = new Point(118, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 137);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // preciosToolStripMenuItem
            // 
            preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            preciosToolStripMenuItem.Size = new Size(70, 24);
            preciosToolStripMenuItem.Text = "Precios";
            preciosToolStripMenuItem.Click += preciosToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Bookstrore App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem zonasToolStripMenuItem;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem subZonasToolStripMenuItem;
        private ToolStripMenuItem provinciasToolStripMenuItem;
        private ToolStripMenuItem comrpobanToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem notaDeCreditoToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem condicionVentaToolStripMenuItem;
        private ToolStripMenuItem vendedoresToolStripMenuItem;
        private ToolStripMenuItem listasDePreciosToolStripMenuItem;
        private ToolStripMenuItem preciosToolStripMenuItem;
    }
}
