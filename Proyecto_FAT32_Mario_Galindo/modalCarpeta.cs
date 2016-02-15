using System;
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
    public partial class modalCarpeta : Form
    {
        public modalCarpeta()
        {
            InitializeComponent();
        }

        //Varibles del nombre de la carpeta
        public string nombreCarpeta;

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            nombreCarpeta = txtNombreCarpeta.Text;
        }
    }
}
