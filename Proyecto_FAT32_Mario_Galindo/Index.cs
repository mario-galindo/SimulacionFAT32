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

        //Variables para recibir el nombre de la a unidad y el tamano
        public string nombre_Disco;
        public string tamano_Disco;

        //Equivalencias GB
        public double GB_bytes = 1073741824;
        public double tamano_original;
        public double resultado_Bytes;

        //Propiedades de la FAT
        public double Espacio_ocupado_FAT;
        public double Porcentaje_Ocupacion;

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalDisco mDisco = new modalDisco();
            DialogResult dr = mDisco.ShowDialog();

            nombre_Disco = mDisco.nombreDisco;
            tamano_Disco = mDisco.tamanoDisco;

            //Convertimos a tipo INT el tamano que nos viene del formulario
            tamano_original = int.Parse(tamano_Disco);

            //Lo Convertimos de GB A Equivalencia en Bytes
            resultado_Bytes = tamano_original * GB_bytes;

            //Calculos para sacar el espacio de la FAT
            Espacio_ocupado_FAT = 0.2 * resultado_Bytes;
            Porcentaje_Ocupacion = resultado_Bytes / Espacio_ocupado_FAT;

            //Le asignamos el porcentaje Ocupado al Label
            lbPorcentaje.Text = Convert.ToString(Porcentaje_Ocupacion + " %");

            //Incrementamos la Progress Bar
            ProgresbarEspacio.Increment(int.Parse(Convert.ToString(Porcentaje_Ocupacion)));



            if (dr == DialogResult.OK)
            {
                //Se agrega el nodo al arbol de directorio(treeview)
                trvDirectorio.Nodes.Add("💾 " + nombre_Disco);

                //se manda a crear una carpeta fisica al disco local C para simular la unidad
                System.IO.Directory.CreateDirectory("c:/ArchivosFAT32/"+nombre_Disco);

                //se muestra el total de espacio
                lbMostarEspacio.Text = Convert.ToString(resultado_Bytes+" bytes");
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
