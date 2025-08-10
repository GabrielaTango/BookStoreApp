namespace UI.Entities
{
    partial class FrmPrecio
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPrecio = new NumericUpDown();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Location = new Point(13, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precio";
            // 
            // button1
            // 
            button1.Location = new Point(229, 30);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 10;
            button1.Text = "B";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(267, 97);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 99);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 67);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 34);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Código:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(98, 97);
            txtPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 27);
            txtPrecio.TabIndex = 4;
            txtPrecio.Enter += txtPrecio_Enter;
            txtPrecio.KeyDown += txtPrecio_KeyDown;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(98, 64);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(242, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(98, 31);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // FrmPrecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 158);
            Controls.Add(groupBox1);
            Name = "FrmPrecio";
            Text = "Nuevo";
            Load += FrmPrecio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
    }
}