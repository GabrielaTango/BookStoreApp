namespace UI.Procesos
{
    partial class FrmFacturador
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDomicilioComercial = new TextBox();
            txtDomicilioParticular = new TextBox();
            txtNombreCliente = new TextBox();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            txtNroDocumento = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 9;
            label3.Text = "Domicilio Particular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 109);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 8;
            label2.Text = "Domicilio Comenrcial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 10);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Codigo";
            // 
            // txtDomicilioComercial
            // 
            txtDomicilioComercial.Enabled = false;
            txtDomicilioComercial.Location = new Point(172, 106);
            txtDomicilioComercial.Name = "txtDomicilioComercial";
            txtDomicilioComercial.Size = new Size(587, 27);
            txtDomicilioComercial.TabIndex = 6;
            // 
            // txtDomicilioParticular
            // 
            txtDomicilioParticular.Enabled = false;
            txtDomicilioParticular.Location = new Point(172, 73);
            txtDomicilioParticular.Name = "txtDomicilioParticular";
            txtDomicilioParticular.Size = new Size(587, 27);
            txtDomicilioParticular.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(172, 40);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(357, 27);
            txtNombreCliente.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(535, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(172, 7);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(112, 27);
            txtCodigo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1091, 169);
            dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 38);
            label4.TabIndex = 2;
            label4.Text = "Factura";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 48);
            panel1.TabIndex = 3;
            panel1.Resize += panel1_Resize;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1091, 33);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 3;
            label5.Text = "Datos de Cliente";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 238);
            panel3.Name = "panel3";
            panel3.Size = new Size(1091, 33);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 3;
            label6.Text = "Articulos";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(1091, 33);
            panel4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 3;
            label7.Text = "Totales";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 473);
            panel5.Name = "panel5";
            panel5.Size = new Size(1091, 243);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNroDocumento);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(btnBuscar);
            panel6.Controls.Add(txtCodigo);
            panel6.Controls.Add(txtNombreCliente);
            panel6.Controls.Add(txtDomicilioParticular);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(txtDomicilioComercial);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 81);
            panel6.Name = "panel6";
            panel6.Size = new Size(1091, 157);
            panel6.TabIndex = 13;
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Enabled = false;
            txtNroDocumento.Location = new Point(290, 8);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(239, 27);
            txtNroDocumento.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 43);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 10;
            label8.Text = "Nombre";
            // 
            // FrmFacturador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 716);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FrmFacturador";
            Text = "FrmFacturador";
            Load += FrmFacturador_Load;
            KeyDown += FrmFacturador_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDomicilioComercial;
        private TextBox txtDomicilioParticular;
        private TextBox txtNombreCliente;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private DataGridView dataGridView1;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtNroDocumento;
        private Label label8;
    }
}