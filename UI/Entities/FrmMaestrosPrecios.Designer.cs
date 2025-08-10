namespace UI.Entities
{
    partial class FrmMaestrosPrecios
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
            components = new System.ComponentModel.Container();
            cmbLista = new ComboBox();
            dataGridView1 = new DataGridView();
            cmPrecios = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmPrecios.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbLista
            // 
            cmbLista.FormattingEnabled = true;
            cmbLista.Location = new Point(167, 61);
            cmbLista.Name = "cmbLista";
            cmbLista.Size = new Size(466, 28);
            cmbLista.TabIndex = 0;
            cmbLista.SelectedIndexChanged += cmbLista_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = cmPrecios;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 325);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // cmPrecios
            // 
            cmPrecios.ImageScalingSize = new Size(20, 20);
            cmPrecios.Items.AddRange(new ToolStripItem[] { borrarToolStripMenuItem });
            cmPrecios.Name = "cmPrecios";
            cmPrecios.Size = new Size(120, 28);
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(119, 24);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Lista";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbLista);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(686, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMaestrosPrecios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmMaestrosPrecios";
            Text = "Modificacion de Precios";
            Load += FrmPrecios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmPrecios.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLista;
        private DataGridView dataGridView1;
        private ContextMenuStrip cmPrecios;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}