using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FAT32_Mario_Galindo
{

    
    public partial class Index : Form
    {
       
        public Index()
        {
            InitializeComponent();
        }

        //Variables
        public string nombre_Disco;
        public string tamano_Disco;

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalDisco mDisco = new modalDisco();
            DialogResult dr = mDisco.ShowDialog();

            nombre_Disco = mDisco.nombreDisco;
            tamano_Disco = mDisco.tamanoDisco;

            if (dr == DialogResult.OK)
            {
                trvDirectorio.Nodes.Add("💾 " + nombre_Disco);
            }
            
        }

        private void crearArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modalArchivo mArchivo = new modalArchivo();
            DialogResult dr = new DialogResult();
            dr = mArchivo.ShowDialog();

         }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            trvDirectorio.Nodes.Add(txt1.Text);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            int indexItem;
            foreach (TreeNode n in trvDirectorio.Nodes) {

                
                if (n.Text.ToLower() == txtnodo.Text)
                {
                    indexItem = n.Index;
                    trvDirectorio.Nodes[indexItem].Nodes.Add(txtarc.Text);
                    
                }
            
            }

            
            
            
        }
    }
}
