namespace UI.Procesos
{
    partial class FrmAgregarArticulo
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
            btnAgregar = new Button();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            txtPrecio = new NumericUpDown();
            txtCantidad = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 179);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(289, 64);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(22, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(185, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(126, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(22, 91);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(289, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Location = new Point(161, 146);
            txtPrecio.Maximum = new decimal(new int[] { 99000000, 0, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 27);
            txtPrecio.TabIndex = 4;
            txtPrecio.KeyDown += NumericUpDown_KeyDown;
            // 
            // txtCantidad
            // 
            txtCantidad.DecimalPlaces = 2;
            txtCantidad.Location = new Point(22, 146);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(126, 27);
            txtCantidad.TabIndex = 3;
            txtCantidad.KeyDown += NumericUpDown_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 68);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 123);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 123);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 11);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Codigo";
            // 
            // FrmAgregarArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 256);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigo);
            Controls.Add(btnAgregar);
            Name = "FrmAgregarArticulo";
            Text = "Agregar Articulo";
            Load += FrmAgregarArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtCodigo;
        private Button btnBuscar;
        private TextBox txtDescripcion;
        private NumericUpDown txtPrecio;
        private NumericUpDown txtCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}