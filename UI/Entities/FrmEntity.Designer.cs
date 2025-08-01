
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
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(156, 268);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 27);
            txtDescripcion.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(156, 235);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(215, 27);
            txtCodigo.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(156, 202);
            txtId.Name = "txtId";
            txtId.Size = new Size(22, 27);
            txtId.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(296, 336);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // FrmEntity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}