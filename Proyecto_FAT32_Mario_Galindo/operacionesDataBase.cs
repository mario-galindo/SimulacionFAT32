using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_FAT32_Mario_Galindo
{
    class operacionesDataBase
    {
        public SqlConnection MiConexion;
 
        //Funcion para conectarme a la base de datos
        public void conectar(){
            MiConexion = new SqlConnection("Data Source=GALINDO-PC;Initial Catalog=FAT32;User ID=sa;Password=root");
            MiConexion.Open();
        }

        //Funcion para desconectar
        public void desconectar() {
            MiConexion.Close();
        }

        //Ejecutar Consulta SQL
        public void EjecutarSQL(String Query)
        {
            SqlCommand MiComando = new SqlCommand(Query, this.MiConexion);
            MiComando.ExecuteNonQuery();
            /*Ejecutamos la consulta sql
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
                MessageBox.Show("Operacion realizada exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo realizar la modificacion de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
             */
         }


        //Consulta que nos retorna un escalar
        public long EjecutarSQLEscalar(String Query)
        {
            this.conectar();
            SqlCommand MiComando = new SqlCommand(Query, this.MiConexion);
            //Ejecutamos la consulta sql
            return Convert.ToInt64(MiComando.ExecuteScalar()); 
            

        }

    }
}
