namespace UI.Entities
{
    partial class FrmArticulo
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
            btnGuardar = new Button();
            txtId = new TextBox();
            txtCodigo = new TextBox();
            txtTema = new TextBox();
            txtObservaciones = new TextBox();
            txtDescripcion = new TextBox();
            txtCodBarras = new TextBox();
            txtTomos = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)txtTomos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(481, 242);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(116, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(48, 27);
            txtId.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(116, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(152, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(304, 191);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(271, 27);
            txtTema.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(116, 158);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(459, 27);
            txtObservaciones.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(116, 125);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(252, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(116, 92);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(125, 27);
            txtCodBarras.TabIndex = 6;
            // 
            // txtTomos
            // 
            txtTomos.Location = new Point(116, 191);
            txtTomos.Name = "txtTomos";
            txtTomos.Size = new Size(82, 27);
            txtTomos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 95);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 8;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 29);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 66);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 10;
            label3.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 128);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 11;
            label4.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 194);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 12;
            label5.Text = "Tema:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 161);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 13;
            label6.Text = "Observaciones:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 194);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 14;
            label7.Text = "Tomos:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTema);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodBarras);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTomos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 287);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Articulo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 308);
            Controls.Add(groupBox1);
            Name = "FrmArticulo";
            Text = "Nuevo";
            Load += FrmArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)txtTomos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtId;
        private TextBox txtCodigo;
        private TextBox txtTema;
        private TextBox txtObservaciones;
        private TextBox txtDescripcion;
        private TextBox txtCodBarras;
        private NumericUpDown txtTomos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
    }
}