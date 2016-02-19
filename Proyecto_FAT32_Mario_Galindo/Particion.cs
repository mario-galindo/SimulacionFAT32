using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FAT32_Mario_Galindo
{
    class Particion
    {
        //Objeto para Interactuar con la base de datos
        operacionesDataBase OpsBD = new operacionesDataBase();

       

        //Funcion para actualizar la MBR al incicio cuando se crea la primera particion
        public void insertarParticion(string nombre,double tamano,double usado){

            //Armamos nuestro Query
           string QueryInsertar = "insert into Particion (nombre,tamano,usado) values('"+nombre+"',"+tamano+","+usado+")";
            

            //Nos conectamos a la base de datos
            OpsBD.conectar();

            //Ejecutamos la consulta
            OpsBD.EjecutarSQL(QueryInsertar);

            //Nos desconectamos
            OpsBD.desconectar();

        }


    }
}
