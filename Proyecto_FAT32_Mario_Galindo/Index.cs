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
using System.IO;
using System.IO.Compression;
using System.Globalization;

namespace Proyecto_FAT32_Mario_Galindo
{


    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
            crearArchivoToolStripMenuItem1.Enabled = false;
            crearCarpetaToolStripMenuItem.Enabled = false;

        }

        //Variables para recibir el nombre de la a unidad y el tamano
        public string nombre_Disco;
        public string tamano_Disco;

        //Equivalencias GB
        public double GB_bytes = 1073741824;
        public double tamano_original;
        public double resultado_Bytes;

        //Propiedades al inicio de la FAT
        public double Espacio_ocupado_FAT;
        public double Porcentaje_Ocupacion;

        //Varibles para el Archivo
        public string Archivo_Nombre;
        public int tamano_ArchivoCreado;
        public DateTime fechaCreacion;
        public string url;

        //Varible para la carpeta
        public string Carpeta_Nombre;

        //Creacion del Disco y Asignacion en la Master Boot Table
        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalDisco mDisco = new modalDisco();
            DialogResult dr = mDisco.ShowDialog();

            nombre_Disco = mDisco.nombreDisco;
            tamano_Disco = mDisco.tamanoDisco;

            //Creamos la Instancia de nuestra clase
            Particion particion = new Particion();


            if (dr == DialogResult.OK)
            {

                //Convertimos a tipo INT el tamano que nos viene del formulario
                tamano_original = int.Parse(tamano_Disco);

                //Lo Convertimos de GB A Equivalencia en Bytes
                resultado_Bytes = tamano_original * GB_bytes;

                //Calculos para sacar el espacio de la FAT
                Espacio_ocupado_FAT = 0.2 * resultado_Bytes;
                Porcentaje_Ocupacion = resultado_Bytes / Espacio_ocupado_FAT;


                //Le asignamos el porcentaje Ocupado al Label
                lbPorcentaje.Text = Convert.ToString(Porcentaje_Ocupacion + " %");

                //Usado
                lbusado.Text = Convert.ToString(Espacio_ocupado_FAT);

                //disponible
                lbdisponible.Text = Convert.ToString(resultado_Bytes - Espacio_ocupado_FAT + " bytes");

                lbtotalgb.Text = Convert.ToString((resultado_Bytes - Espacio_ocupado_FAT) / (1073741824) + " GB");

                //Incrementamos la Progress Bar
                ProgresbarEspacio.Increment(int.Parse(Convert.ToString(Porcentaje_Ocupacion)));

                //Se agrega el nodo al arbol de directorio(treeview)
                trvDirectorio.Nodes.Add(nombre_Disco);

                //se manda a crear una carpeta fisica al disco local C para simular la unidad
                System.IO.Directory.CreateDirectory("c:/ArchivosFAT32/" + nombre_Disco);

                //se muestra el total de espacio
                lbMostarEspacio.Text = Convert.ToString(resultado_Bytes + " bytes");

                //Deshabilitamos el boton de crear disco
                crearArchivoToolStripMenuItem.Enabled = false;

                //Habilitamos el boton de crear Archivo
                crearArchivoToolStripMenuItem1.Enabled = true;

                //Habilitamos el boton de crear carpeta
                crearCarpetaToolStripMenuItem.Enabled = true;

                //Mandamos a llamar nuestra funcion que nos llene nuestra MBR
                particion.insertarParticion(nombre_Disco, resultado_Bytes, Espacio_ocupado_FAT);
            }

        }

        public string date;

        //Creacion del Archivo de Texto
        private void crearArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modalArchivo mArchivo = new modalArchivo();
            DialogResult dr = mArchivo.ShowDialog();

            //Capturamos el nombre del Archivo
            Archivo_Nombre = mArchivo.Nombre_Archivo;

            //Creamos instancia de la clase archhivo que nos maneja los datos con la base de datos
            tablaArchivos tabla_FAT = new tablaArchivos();

            if (dr == DialogResult.OK)
            {
                string rutaCreacion = trvDirectorio.SelectedNode.FullPath;

                //File.WriteAllText("c:/ArchivosFAT32/"+ nombre_Disco + "/" + Carpeta_Nombre + "/" + Archivo_Nombre + ".txt", " ");
                File.WriteAllText("c:/ArchivosFAT32/" + rutaCreacion + "/" + Archivo_Nombre + ".txt", " ");

                trvDirectorio.SelectedNode.Nodes.Add(Archivo_Nombre + ".txt");

                //Obtengo la direccion donde se creo
                string url = "c:/ArchivosFAT32/" + rutaCreacion + "/" + Archivo_Nombre + ".txt";


                //Obtener Informacion del archivo
                //FileInfo file = new FileInfo("c:/ArchivosFAT32/" + nombre_Disco + "/" + Carpeta_Nombre + "/" + Archivo_Nombre + ".txt");
                FileInfo file = new FileInfo("c:/ArchivosFAT32/" + rutaCreacion + "/" + Archivo_Nombre + ".txt");

                fechaCreacion = DateTime.Now;
                date = fechaCreacion.Date.ToString("yyyy-MM-dd");



                //Obtenemos el tamano del archivo Creado
                tamano_ArchivoCreado = (int)file.Length;

                //Mandamos los datos del archivo a la File Allocation Table
                tabla_FAT.actualizarFAT32(Archivo_Nombre, tamano_ArchivoCreado, date, url, nombre_Disco);



                //Actualizamos el valor real en la Master Boot
                long usadoActual = tabla_FAT.EspacionDisponible();
                usadoActual = (usadoActual + 1);



                //Actualizamos la Tabla
                tabla_FAT.actualizarUsado(usadoActual, nombre_Disco);

                //Actualizamos nuestra vista
                lbusado.Text = usadoActual.ToString();

                lbdisponible.Text = Convert.ToString(resultado_Bytes - usadoActual + " bytes");


                MessageBox.Show(rutaCreacion);
            }


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
           
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
           




        }

        private void crearCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalCarpeta dialogo = new modalCarpeta();
            DialogResult dr = dialogo.ShowDialog();

            Carpeta_Nombre = dialogo.nombreCarpeta;

            if (dr == DialogResult.OK)
            {
                System.IO.Directory.CreateDirectory("c:/ArchivosFAT32/" + nombre_Disco + "/" + Carpeta_Nombre);
                trvDirectorio.SelectedNode.Nodes.Add(Carpeta_Nombre);
            }
        }
        //Boton de Comprimir
        private void button1_Click(object sender, EventArgs e)
        {
            string dirpath = @"c:\ArchivosFAT32";

            DirectoryInfo di = new DirectoryInfo(dirpath);

            // Compress the directory's files.
            foreach (FileInfo fi in di.GetFiles())
            {
                Compress(fi);

            }


        }

        public static void Compress(FileInfo fi)
        {
            // Get the stream of the source file.
            using (FileStream inFile = fi.OpenRead())
            {
                // Prevent compressing hidden and
                // already compressed files.
                if ((File.GetAttributes(fi.FullName)
                    & FileAttributes.Hidden)
                    != FileAttributes.Hidden & fi.Extension != ".rar")
                {
                    // Create the compressed file.
                    using (FileStream outFile =
                                File.Create(fi.FullName + ".rar"))
                    {
                        using (GZipStream Compress =
                            new GZipStream(outFile,
                            CompressionMode.Compress))
                        {
                            // Copy the source file into
                            // the compression stream.
                            inFile.CopyTo(Compress);

                            MessageBox.Show("Terminado");
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            string Ubicacion = trvDirectorio.SelectedNode.FullPath;

            FileStream strean = new FileStream("c:/ArchivosFAT32/" + Ubicacion, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(strean);
            while (reader.Peek() != -1)
            {
                richTextBox1.Text += reader.ReadLine() + "\r";
            }
            reader.Close();

            FileInfo file = new FileInfo("c:/ArchivosFAT32/" + Ubicacion);
            lbtamano.Text = Convert.ToString(file.Length) + " bytes";
            lbcreacion.Text = Convert.ToString(file.CreationTime);
            lblastaccess.Text = Convert.ToString(file.LastAccessTime);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Ubicacion = trvDirectorio.SelectedNode.FullPath;
            richTextBox1.SaveFile("c:/ArchivosFAT32/"+Ubicacion, RichTextBoxStreamType.PlainText);

            //Creamos instancia de la clase archhivo que nos maneja los datos con la base de datos
            tablaArchivos tabla_FAT = new tablaArchivos();

           

            //Obtener Informacion del archivo para actualizar el valor
            FileInfo file = new FileInfo("c:/ArchivosFAT32/" + Ubicacion);

            
            //Obtenemos el tamano del archivo Creado
            tamano_ArchivoCreado = (int)file.Length;

            
            
            //Mandamos los datos del archivo a la File Allocation Table
            tabla_FAT.actualizarArchivo(Archivo_Nombre, tamano_ArchivoCreado, date, "c:/ArchivosFAT32/" + Ubicacion, nombre_Disco);



            //Actualizamos el valor real en la Master Boot
            long usadoActual = tabla_FAT.EspacionDisponible();
            usadoActual = (usadoActual + tamano_ArchivoCreado);



            //Actualizamos la Tabla
            tabla_FAT.actualizarUsado(usadoActual, nombre_Disco);

            //Actualizamos nuestra vista
            lbusado.Text = usadoActual.ToString();

            lbdisponible.Text = Convert.ToString(resultado_Bytes - usadoActual + " bytes");



            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablaArchivos ManejoFAT = new tablaArchivos();

            string Ubicacion = trvDirectorio.SelectedNode.FullPath;

            FileInfo file = new FileInfo("c:/ArchivosFAT32/" + Ubicacion);

            int tamano_ArchivoBorrado = (int)file.Length;

            string nombreElemento = trvDirectorio.SelectedNode.Text;

            string[] nueva = nombreElemento.Split('.');

            foreach (var item in nueva)
            {
                ManejoFAT.deleteFile(item);
                break;
            }

            //Lo removemos del TreeView
            trvDirectorio.SelectedNode.Remove();
           
            //A restar...
            ManejoFAT.actualizarArchivo(Archivo_Nombre, tamano_ArchivoCreado, date, "c:/ArchivosFAT32/" + Ubicacion, nombre_Disco);

            //Actualizamos el valor real en la Master Boot
            long usadoActual = ManejoFAT.EspacionDisponible();
            usadoActual = (usadoActual - tamano_ArchivoCreado);

            //Actualizamos la Tabla
            ManejoFAT.actualizarUsado(usadoActual, nombre_Disco);

            //Actualizamos nuestra vista
            lbusado.Text = usadoActual.ToString();

            lbdisponible.Text = Convert.ToString(resultado_Bytes - usadoActual + " bytes");

            lbtamano.Text = "";
            lbcreacion.Text = "";
            lblastaccess.Text = "";

        }
    }
}