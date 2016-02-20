using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FAT32_Mario_Galindo
{
    class tablaArchivos
    {
        //Objeto para interactuar con la BD
        operacionesDataBase OpsBD = new operacionesDataBase();

        
        //Funcion para actualizar la File Allocation Table
        public void actualizarFAT32(string nombre,int tamanoArchivo,string f_creacion,string url,string particion_name) { 
            
        //Armamos nuestro Query
        string QueryInsertarFAT32 = "insert into Direcciones (nombreArchivo,tamanoArchivo,fecha_creacion,url,particion_name) values('" + nombre + "'," + tamanoArchivo + "," + f_creacion + ",'" + url + "','" + particion_name + "')";
        
        //Nos conectamos a la Base de Datos
        OpsBD.conectar();

        //Ejecutamos el Query
        OpsBD.EjecutarSQL(QueryInsertarFAT32);

        //Nos desconectamos de la Base de Datos
        OpsBD.desconectar();

        }


        public long EspacionDisponible() {

            string Query_espacio = "select p.usado from Particion p";

            return OpsBD.EjecutarSQLEscalar(Query_espacio);
        }


        public void actualizarUsado(long nuevo,string particion) {

            string Query_Actualizar = "update Particion set usado = " + nuevo + " where nombre = '" + particion + "' ";

            OpsBD.conectar();

            OpsBD.EjecutarSQL(Query_Actualizar);

            OpsBD.desconectar();
        }

        public void actualizarArchivo(string nombre,int tamanoArchivo,string f_creacion,string url,string particion_name) {

            //Armamos nuestro Query
            string QueryActualizarFAT32 = "update Direcciones set nombreArchivo = '" + nombre + "', tamanoArchivo = " + tamanoArchivo + ",fecha_creacion = " + f_creacion + ", url = '" + url + "',particion_name = '" + particion_name + "' where nombreArchivo = '" + nombre + "'";

            //Nos conectamos a la Base de Datos
            OpsBD.conectar();

            //Ejecutamos el Query
            OpsBD.EjecutarSQL(QueryActualizarFAT32);

            //Nos desconectamos de la Base de Datos
            OpsBD.desconectar();


        }

    }
}
