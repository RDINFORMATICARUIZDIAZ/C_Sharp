using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;


namespace MICRUD.Datos
{
    public class CONEXIONMAESTRA
    {

        public static string conexion = "Data source=OSCAR_ACER\\SERVERSQL; Initial Catalog=System; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection (conexion);
        public static void abrir()
        {
            if(conectar.State ==ConnectionState.Closed)
            {
                conectar.Open ();
            }
        }
        public static void cerrar()
        { 
            if(conectar.State== ConnectionState.Open)
            {
                conectar.Close ();
            }
        }
    }

        
}
