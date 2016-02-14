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
    public partial class modalDisco : Form
    {
       
        public modalDisco()
        {
            InitializeComponent();
        }

        public string nombreDisco = "";
        public string tamanoDisco = "";

        private void btnCrear_Click(object sender, EventArgs e)
        {
           
            nombreDisco = txtNombreDisco.Text;
            tamanoDisco = txtTamanoDisco.Text;
            

        }
    }
}
