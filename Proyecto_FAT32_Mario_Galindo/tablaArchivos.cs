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

    }
}
