namespace Proyecto_FAT32_Mario_Galindo
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearArchivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvDirectorio = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtotalgb = new System.Windows.Forms.Label();
            this.lbdisponible = new System.Windows.Forms.Label();
            this.lbusado = new System.Windows.Forms.Label();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.lbMostarEspacio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ProgresbarEspacio = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbtamano = new System.Windows.Forms.Label();
            this.lbcreacion = new System.Windows.Forms.Label();
            this.lblastaccess = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearArchivoToolStripMenuItem,
            this.crearCarpetaToolStripMenuItem,
            this.crearArchivoToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // crearArchivoToolStripMenuItem
            // 
            this.crearArchivoToolStripMenuItem.Name = "crearArchivoToolStripMenuItem";
            this.crearArchivoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearArchivoToolStripMenuItem.Text = "Crear Disco";
            this.crearArchivoToolStripMenuItem.Click += new System.EventHandler(this.crearArchivoToolStripMenuItem_Click);
            // 
            // crearCarpetaToolStripMenuItem
            // 
            this.crearCarpetaToolStripMenuItem.Name = "crearCarpetaToolStripMenuItem";
            this.crearCarpetaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearCarpetaToolStripMenuItem.Text = "Crear Carpeta";
            this.crearCarpetaToolStripMenuItem.Click += new System.EventHandler(this.crearCarpetaToolStripMenuItem_Click);
            // 
            // crearArchivoToolStripMenuItem1
            // 
            this.crearArchivoToolStripMenuItem1.Name = "crearArchivoToolStripMenuItem1";
            this.crearArchivoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.crearArchivoToolStripMenuItem1.Text = "Crear Archivo";
            this.crearArchivoToolStripMenuItem1.Click += new System.EventHandler(this.crearArchivoToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvDirectorio);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(969, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvDirectorio
            // 
            this.trvDirectorio.Location = new System.Drawing.Point(10, 15);
            this.trvDirectorio.Name = "trvDirectorio";
            this.trvDirectorio.Size = new System.Drawing.Size(183, 598);
            this.trvDirectorio.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.lblastaccess);
            this.splitContainer2.Panel1.Controls.Add(this.lbcreacion);
            this.splitContainer2.Panel1.Controls.Add(this.lbtamano);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(765, 620);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtotalgb);
            this.groupBox1.Controls.Add(this.lbdisponible);
            this.groupBox1.Controls.Add(this.lbusado);
            this.groupBox1.Controls.Add(this.lbPorcentaje);
            this.groupBox1.Controls.Add(this.lbMostarEspacio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ProgresbarEspacio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
            // 
            // lbtotalgb
            // 
            this.lbtotalgb.AutoSize = true;
            this.lbtotalgb.Location = new System.Drawing.Point(579, 121);
            this.lbtotalgb.Name = "lbtotalgb";
            this.lbtotalgb.Size = new System.Drawing.Size(16, 13);
            this.lbtotalgb.TabIndex = 15;
            this.lbtotalgb.Text = "   ";
            // 
            // lbdisponible
            // 
            this.lbdisponible.AutoSize = true;
            this.lbdisponible.Location = new System.Drawing.Point(131, 121);
            this.lbdisponible.Name = "lbdisponible";
            this.lbdisponible.Size = new System.Drawing.Size(0, 13);
            this.lbdisponible.TabIndex = 14;
            // 
            // lbusado
            // 
            this.lbusado.AutoSize = true;
            this.lbusado.Location = new System.Drawing.Point(117, 96);
            this.lbusado.Name = "lbusado";
            this.lbusado.Size = new System.Drawing.Size(0, 13);
            this.lbusado.TabIndex = 13;
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Location = new System.Drawing.Point(364, 191);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lbPorcentaje.TabIndex = 12;
            // 
            // lbMostarEspacio
            // 
            this.lbMostarEspacio.AutoSize = true;
            this.lbMostarEspacio.Location = new System.Drawing.Point(105, 142);
            this.lbMostarEspacio.Name = "lbMostarEspacio";
            this.lbMostarEspacio.Size = new System.Drawing.Size(0, 13);
            this.lbMostarEspacio.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Total Espacio:";
            // 
            // ProgresbarEspacio
            // 
            this.ProgresbarEspacio.Location = new System.Drawing.Point(120, 185);
            this.ProgresbarEspacio.Name = "ProgresbarEspacio";
            this.ProgresbarEspacio.Size = new System.Drawing.Size(238, 23);
            this.ProgresbarEspacio.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Capacidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(643, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "_________________________________________________________________________________" +
    "_________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "  ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Espacion disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Espacio usado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(643, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "_________________________________________________________________________________" +
    "_________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de archivos: FAT32";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo: Disco local";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Comprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 228);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Informacion del Archivo";
            // 
            // lbtamano
            // 
            this.lbtamano.AutoSize = true;
            this.lbtamano.Location = new System.Drawing.Point(452, 56);
            this.lbtamano.Name = "lbtamano";
            this.lbtamano.Size = new System.Drawing.Size(10, 13);
            this.lbtamano.TabIndex = 13;
            this.lbtamano.Text = ".";
            // 
            // lbcreacion
            // 
            this.lbcreacion.AutoSize = true;
            this.lbcreacion.Location = new System.Drawing.Point(452, 74);
            this.lbcreacion.Name = "lbcreacion";
            this.lbcreacion.Size = new System.Drawing.Size(10, 13);
            this.lbcreacion.TabIndex = 14;
            this.lbcreacion.Text = ".";
            // 
            // lblastaccess
            // 
            this.lblastaccess.AutoSize = true;
            this.lblastaccess.Location = new System.Drawing.Point(452, 95);
            this.lblastaccess.Name = "lblastaccess";
            this.lblastaccess.Size = new System.Drawing.Size(10, 13);
            this.lblastaccess.TabIndex = 15;
            this.lblastaccess.Text = ".";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Guardar Informacion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 644);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto I - Mario Galindo - FAT32";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearArchivoToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar ProgresbarEspacio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TreeView trvDirectorio;
        private System.Windows.Forms.Label lbMostarEspacio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.ToolStripMenuItem crearCarpetaToolStripMenuItem;
        private System.Windows.Forms.Label lbusado;
        private System.Windows.Forms.Label lbdisponible;
        private System.Windows.Forms.Label lbtotalgb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbtamano;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbcreacion;
        private System.Windows.Forms.Label lblastaccess;
        private System.Windows.Forms.Button button4;
    }
}

