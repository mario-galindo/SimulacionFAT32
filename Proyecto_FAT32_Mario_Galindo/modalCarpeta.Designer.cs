namespace Proyecto_FAT32_Mario_Galindo
{
    partial class modalCarpeta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnCrearCarpeta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCarpeta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnCrearCarpeta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreCarpeta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear nueva carpeta";
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(137, 66);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrearCarpeta
            // 
            this.btnCrearCarpeta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrearCarpeta.Location = new System.Drawing.Point(55, 67);
            this.btnCrearCarpeta.Name = "btnCrearCarpeta";
            this.btnCrearCarpeta.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCarpeta.TabIndex = 2;
            this.btnCrearCarpeta.Text = "Crear";
            this.btnCrearCarpeta.UseVisualStyleBackColor = true;
            this.btnCrearCarpeta.Click += new System.EventHandler(this.btnCrearCarpeta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Carpeta:";
            // 
            // txtNombreCarpeta
            // 
            this.txtNombreCarpeta.Location = new System.Drawing.Point(137, 30);
            this.txtNombreCarpeta.Name = "txtNombreCarpeta";
            this.txtNombreCarpeta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCarpeta.TabIndex = 0;
            // 
            // modalCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 131);
            this.Controls.Add(this.groupBox1);
            this.Name = "modalCarpeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Carpeta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnCrearCarpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCarpeta;
    }
}