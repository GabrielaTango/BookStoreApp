namespace UI
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDomComercial = new TextBox();
            txtDomParticular = new TextBox();
            txtCodigoPostal = new TextBox();
            dtpFechaAlta = new DateTimePicker();
            dtpFechaInha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbProvincia = new ComboBox();
            txtTelefono = new TextBox();
            txtTelefonoMovil = new TextBox();
            txtEmail = new TextBox();
            txtContacto = new TextBox();
            cmbTipoDoc = new ComboBox();
            cmbCategoriaIva = new ComboBox();
            txtNroDoc = new TextBox();
            txtIIBB = new TextBox();
            txtObservaciones = new TextBox();
            nudDescuento = new NumericUpDown();
            cmbCondicionPago = new ComboBox();
            chkSoloContado = new CheckBox();
            cmbZona = new ComboBox();
            cmbSubZona = new ComboBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(116, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(118, 27);
            txtCodigo.TabIndex = 0;
            txtCodigo.Validating += Fields_Validating;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(680, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Validating += Fields_Validating;
            // 
            // txtDomComercial
            // 
            txtDomComercial.Location = new Point(160, 45);
            txtDomComercial.Name = "txtDomComercial";
            txtDomComercial.Size = new Size(323, 27);
            txtDomComercial.TabIndex = 2;
            txtDomComercial.Validating += Fields_Validating;
            // 
            // txtDomParticular
            // 
            txtDomParticular.Location = new Point(160, 78);
            txtDomParticular.Name = "txtDomParticular";
            txtDomParticular.Size = new Size(323, 27);
            txtDomParticular.TabIndex = 3;
            txtDomParticular.Validating += Fields_Validating;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(160, 145);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(323, 27);
            txtCodigoPostal.TabIndex = 5;
            txtCodigoPostal.Validating += Fields_Validating;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(269, 35);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(250, 27);
            dtpFechaAlta.TabIndex = 6;
            dtpFechaAlta.Validating += Fields_Validating;
            // 
            // dtpFechaInha
            // 
            dtpFechaInha.Location = new Point(546, 35);
            dtpFechaInha.Name = "dtpFechaInha";
            dtpFechaInha.Size = new Size(250, 27);
            dtpFechaInha.TabIndex = 7;
            dtpFechaInha.Validating += Fields_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 9;
            label3.Text = "Domicilio Comercial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 9;
            label4.Text = "Domicilio Particular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 148);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 10;
            label5.Text = "Código Postal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 114);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Provincia:";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(160, 111);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(323, 28);
            cmbProvincia.TabIndex = 11;
            cmbProvincia.Validating += Fields_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(158, 21);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(323, 27);
            txtTelefono.TabIndex = 12;
            txtTelefono.Validating += Fields_Validating;
            // 
            // txtTelefonoMovil
            // 
            txtTelefonoMovil.Location = new Point(159, 54);
            txtTelefonoMovil.Name = "txtTelefonoMovil";
            txtTelefonoMovil.Size = new Size(323, 27);
            txtTelefonoMovil.TabIndex = 12;
            txtTelefonoMovil.Validating += Fields_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 12;
            txtEmail.Validating += Fields_Validating;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(158, 120);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(323, 27);
            txtContacto.TabIndex = 12;
            txtContacto.Validating += Fields_Validating;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new Point(98, 26);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(82, 28);
            cmbTipoDoc.TabIndex = 13;
            cmbTipoDoc.Validating += Fields_Validating;
            // 
            // cmbCategoriaIva
            // 
            cmbCategoriaIva.FormattingEnabled = true;
            cmbCategoriaIva.Location = new Point(99, 60);
            cmbCategoriaIva.Name = "cmbCategoriaIva";
            cmbCategoriaIva.Size = new Size(323, 28);
            cmbCategoriaIva.TabIndex = 13;
            cmbCategoriaIva.Validating += Fields_Validating;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(186, 26);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(235, 27);
            txtNroDoc.TabIndex = 14;
            txtNroDoc.Validating += Fields_Validating;
            // 
            // txtIIBB
            // 
            txtIIBB.Location = new Point(98, 94);
            txtIIBB.Name = "txtIIBB";
            txtIIBB.Size = new Size(235, 27);
            txtIIBB.TabIndex = 14;
            txtIIBB.Validating += Fields_Validating;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Dock = DockStyle.Bottom;
            txtObservaciones.Location = new Point(0, 528);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(1138, 199);
            txtObservaciones.TabIndex = 14;
            txtObservaciones.Validating += Fields_Validating;
            // 
            // nudDescuento
            // 
            nudDescuento.Location = new Point(96, 169);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(150, 27);
            nudDescuento.TabIndex = 15;
            nudDescuento.Validating += Fields_Validating;
            // 
            // cmbCondicionPago
            // 
            cmbCondicionPago.FormattingEnabled = true;
            cmbCondicionPago.Location = new Point(99, 135);
            cmbCondicionPago.Name = "cmbCondicionPago";
            cmbCondicionPago.Size = new Size(323, 28);
            cmbCondicionPago.TabIndex = 13;
            cmbCondicionPago.Validating += Fields_Validating;
            // 
            // chkSoloContado
            // 
            chkSoloContado.AutoSize = true;
            chkSoloContado.Location = new Point(211, 15);
            chkSoloContado.Name = "chkSoloContado";
            chkSoloContado.Size = new Size(122, 24);
            chkSoloContado.TabIndex = 16;
            chkSoloContado.Text = "Solo Contado";
            chkSoloContado.UseVisualStyleBackColor = true;
            // 
            // cmbZona
            // 
            cmbZona.FormattingEnabled = true;
            cmbZona.Location = new Point(88, 33);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(338, 28);
            cmbZona.TabIndex = 11;
            cmbZona.Validating += Fields_Validating;
            // 
            // cmbSubZona
            // 
            cmbSubZona.FormattingEnabled = true;
            cmbSubZona.Location = new Point(88, 80);
            cmbSubZona.Name = "cmbSubZona";
            cmbSubZona.Size = new Size(338, 28);
            cmbSubZona.TabIndex = 11;
            cmbSubZona.Validating += Fields_Validating;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1138, 27);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Guardar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Cancelar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(dtpFechaAlta);
            groupBox1.Controls.Add(dtpFechaInha);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(993, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDomComercial);
            groupBox2.Controls.Add(txtDomParticular);
            groupBox2.Controls.Add(chkSoloContado);
            groupBox2.Controls.Add(txtCodigoPostal);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbProvincia);
            groupBox2.Location = new Point(14, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 178);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(txtTelefonoMovil);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtContacto);
            groupBox3.Location = new Point(16, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 165);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contacto";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 123);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 13;
            label10.Text = "Contacto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 90);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 13;
            label9.Text = "E-mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 57);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 13;
            label8.Text = "Teléfono Movil:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 28);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 13;
            label7.Text = "Teléfono:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbTipoDoc);
            groupBox4.Controls.Add(cmbCategoriaIva);
            groupBox4.Controls.Add(cmbCondicionPago);
            groupBox4.Controls.Add(txtNroDoc);
            groupBox4.Controls.Add(txtIIBB);
            groupBox4.Controls.Add(nudDescuento);
            groupBox4.Location = new Point(558, 292);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(447, 217);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Facturación";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(cmbZona);
            groupBox5.Controls.Add(cmbSubZona);
            groupBox5.Location = new Point(558, 161);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(451, 125);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Zona";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 83);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 12;
            label12.Text = "Sub Zona";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 36);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 12;
            label11.Text = "Zona";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 727);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(txtObservaciones);
            Name = "FrmCliente";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDomComercial;
        private TextBox txtDomParticular;
        private TextBox txtCodigoPostal;
        private DateTimePicker dtpFechaAlta;
        private DateTimePicker dtpFechaInha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbProvincia;
        private TextBox txtTelefono;
        private TextBox txtTelefonoMovil;
        private TextBox txtEmail;
        private TextBox txtContacto;
        private ComboBox cmbTipoDoc;
        private ComboBox cmbCategoriaIva;
        private TextBox txtNroDoc;
        private TextBox txtIIBB;
        private TextBox txtObservaciones;
        private NumericUpDown nudDescuento;
        private ComboBox cmbCondicionPago;
        private CheckBox chkSoloContado;
        private ComboBox cmbZona;
        private ComboBox cmbSubZona;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox5;
        private Label label12;
        private Label label11;
        private ErrorProvider errorProvider1;
    }
}