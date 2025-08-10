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
            dgvDetalles = new DataGridView();
            lblComprobante = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            panelCuotas = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            txtValorCuota = new NumericUpDown();
            txtCuotas = new NumericUpDown();
            txtAnticipo = new NumericUpDown();
            panel7 = new Panel();
            lblDescuento = new Label();
            label4 = new Label();
            lblTotalTittle = new Label();
            lblTotal = new Label();
            btnGuardar = new Button();
            panel6 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            cmbListas = new ComboBox();
            cmbVendedor = new ComboBox();
            txtFecha = new TextBox();
            txtNumeroComprobante = new TextBox();
            txtNroDocumento = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtValorCuota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCuotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAnticipo).BeginInit();
            panel7.SuspendLayout();
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
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Dock = DockStyle.Fill;
            dgvDetalles.Location = new Point(0, 271);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(1091, 169);
            dgvDetalles.TabIndex = 3;
            dgvDetalles.CellDoubleClick += dgvDetalles_CellDoubleClick;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(490, 0);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(113, 38);
            lblComprobante.TabIndex = 2;
            lblComprobante.Text = "Factura";
            lblComprobante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblComprobante);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 48);
            panel1.TabIndex = 3;
            panel1.Resize += panel1_Resize;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
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
            panel3.BackColor = Color.SteelBlue;
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
            panel4.BackColor = Color.SteelBlue;
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
            panel5.Controls.Add(panelCuotas);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 473);
            panel5.Name = "panel5";
            panel5.Size = new Size(1091, 243);
            panel5.TabIndex = 12;
            // 
            // panelCuotas
            // 
            panelCuotas.Controls.Add(label10);
            panelCuotas.Controls.Add(label9);
            panelCuotas.Controls.Add(txtValorCuota);
            panelCuotas.Controls.Add(txtCuotas);
            panelCuotas.Controls.Add(txtAnticipo);
            panelCuotas.Location = new Point(13, 6);
            panelCuotas.Name = "panelCuotas";
            panelCuotas.Size = new Size(571, 109);
            panelCuotas.TabIndex = 4;
            panelCuotas.TabStop = false;
            panelCuotas.Text = "Cuotas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 69);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 4;
            label10.Text = "Cuotas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 36);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 3;
            label9.Text = "Anticipo:";
            // 
            // txtValorCuota
            // 
            txtValorCuota.Location = new Point(302, 67);
            txtValorCuota.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.Size = new Size(150, 27);
            txtValorCuota.TabIndex = 2;
            txtValorCuota.ValueChanged += txtParaCuotas_ValueChanged;
            txtValorCuota.Enter += NumericUpDown_Enter;
            txtValorCuota.KeyDown += txtParaCuotas_KeyDown;
            // 
            // txtCuotas
            // 
            txtCuotas.Location = new Point(146, 67);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.Size = new Size(150, 27);
            txtCuotas.TabIndex = 1;
            txtCuotas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtCuotas.ValueChanged += txtParaCuotas_ValueChanged;
            txtCuotas.Enter += NumericUpDown_Enter;
            txtCuotas.KeyDown += txtParaCuotas_KeyDown;
            // 
            // txtAnticipo
            // 
            txtAnticipo.Location = new Point(146, 34);
            txtAnticipo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtAnticipo.Name = "txtAnticipo";
            txtAnticipo.Size = new Size(150, 27);
            txtAnticipo.TabIndex = 0;
            txtAnticipo.ValueChanged += txtParaCuotas_ValueChanged;
            txtAnticipo.Enter += NumericUpDown_Enter;
            txtAnticipo.KeyDown += txtParaCuotas_KeyDown;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblDescuento);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(lblTotalTittle);
            panel7.Controls.Add(lblTotal);
            panel7.Controls.Add(btnGuardar);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(597, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(494, 243);
            panel7.TabIndex = 3;
            // 
            // lblDescuento
            // 
            lblDescuento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDescuento.Location = new Point(295, 19);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.RightToLeft = RightToLeft.Yes;
            lblDescuento.Size = new Size(144, 20);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 19);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Descuento";
            // 
            // lblTotalTittle
            // 
            lblTotalTittle.AutoSize = true;
            lblTotalTittle.Location = new Point(236, 53);
            lblTotalTittle.Name = "lblTotalTittle";
            lblTotalTittle.Size = new Size(42, 20);
            lblTotalTittle.TabIndex = 1;
            lblTotalTittle.Text = "Total";
            lblTotalTittle.Click += lblTotalTittle_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Location = new Point(295, 53);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.Yes;
            lblTotal.Size = new Size(144, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(34, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(434, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Obtener CAE y Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(cmbListas);
            panel6.Controls.Add(cmbVendedor);
            panel6.Controls.Add(txtFecha);
            panel6.Controls.Add(txtNumeroComprobante);
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(796, 11);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 18;
            label14.Text = "Numero";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(908, 44);
            label13.Name = "label13";
            label13.Size = new Size(47, 20);
            label13.TabIndex = 17;
            label13.Text = "Fecha";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(796, 109);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 16;
            label12.Text = "Vendedor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(830, 76);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 15;
            label11.Text = "Lista";
            // 
            // cmbListas
            // 
            cmbListas.FormattingEnabled = true;
            cmbListas.Location = new Point(875, 73);
            cmbListas.Name = "cmbListas";
            cmbListas.Size = new Size(190, 28);
            cmbListas.TabIndex = 14;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(875, 105);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(190, 28);
            cmbVendedor.TabIndex = 13;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(961, 41);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(104, 27);
            txtFecha.TabIndex = 12;
            txtFecha.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumeroComprobante
            // 
            txtNumeroComprobante.Enabled = false;
            txtNumeroComprobante.Location = new Point(868, 8);
            txtNumeroComprobante.Name = "txtNumeroComprobante";
            txtNumeroComprobante.Size = new Size(197, 27);
            txtNumeroComprobante.TabIndex = 12;
            txtNumeroComprobante.TextAlign = HorizontalAlignment.Right;
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
            Controls.Add(dgvDetalles);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FrmFacturador";
            Text = "Facturacion";
            Load += FrmFacturador_Load;
            KeyDown += FrmFacturador_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panelCuotas.ResumeLayout(false);
            panelCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtValorCuota).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCuotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAnticipo).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private DataGridView dgvDetalles;
        private Label lblComprobante;
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
        private Button btnGuardar;
        private TextBox txtFecha;
        private TextBox txtNumeroComprobante;
        private Label lblTotal;
        private Label lblTotalTittle;
        private Panel panel7;
        private ComboBox cmbVendedor;
        private ComboBox cmbListas;
        private Label lblDescuento;
        private Label label4;
        private GroupBox panelCuotas;
        private Label label9;
        private NumericUpDown txtValorCuota;
        private NumericUpDown txtCuotas;
        private NumericUpDown txtAnticipo;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}