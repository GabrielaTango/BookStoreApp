
namespace UI
{
    partial class FrmEntity
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
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            txtId = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(105, 81);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 27);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.KeyDown += txt_KeyDown;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(105, 48);
            txtCodigo.MaxLength = 20;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(215, 27);
            txtCodigo.TabIndex = 3;
            txtCodigo.KeyDown += txt_KeyDown;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(105, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(22, 27);
            txtId.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(226, 114);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            btnGuardar.KeyDown += txt_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 18);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // FrmEntity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 155);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtId);
            Controls.Add(txtCodigo);
            Controls.Add(txtDescripcion);
            Name = "FrmEntity";
            Text = "FrmEntity";
            Load += FrmEntity_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private TextBox txtId;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}