using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibliotecaNewSysacad
{
    public static class BDConexion
    {
        public static string stringConexion;
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static BDConexion()
        {
            stringConexion = @"Server=.;Database=NewSysacad;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        
       
    }
}
